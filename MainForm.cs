using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Collections;


namespace BRSARFilePatcher
{
    public partial class MainForm : Form
    {
        private const string musicOffsetsPath = "musicOffsets.xml";
        private ArrayList musicTracks;
        private String brsarPath;
        private String brstmPath;

        public MainForm()
        {
            InitializeComponent();

            musicTracks = new ArrayList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadMusicXml();
            Cursor.Current = Cursors.Default;
        }

        private void BRSAROpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Binary Revolution Stream Archive (.brsar)|*.brsar";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                //Load BRSAR using OpenFileDialog
                BRSAROpenTextbox.Text = openDlg.SafeFileName;
                brsarPath = openDlg.FileName;

                //Enable other Controls
                MusicGroupBox.Enabled = true;
                BRSTMGroupBox.Enabled = true;
            }
        }

        private void BRSARSaveButton_Click(object sender, EventArgs e)
        {

            if (HexTextbox.Text.Length == 0 || MusicComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("An item has not been entered. \nYou must select a music track and load a brstm file before continuing.");
                return;
            }

            //if the user selects no, do nothing
            if (MessageBox.Show("You are about to modify data in the brsar file. \nThis operation cannot be undone. \n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            //if the user selects yes, backup the selected brsar
            if (MessageBox.Show("Want to back-up the BRSAR?", "Backup", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveFileDialog1.Filter = "Binary Revolution Stream Archive (.brsar)|*.brsar";
                saveFileDialog1.ShowDialog();
                File.Copy(brsarPath, saveFileDialog1.FileName, true);
                MessageBox.Show("The BRSAR is backed up!");
            }

            //write bytes to selected BRSAR offset
            MusicTrack currentTrack = (MusicTrack)musicTracks[MusicComboBox.SelectedIndex];
            long offset = Int64.Parse(currentTrack.Offset, System.Globalization.NumberStyles.HexNumber);

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(brsarPath));
            bw.BaseStream.Position = offset;
            bw.Write(HexStringConverter.ToByteArray(HexTextbox.Text)); //needs testing
            bw.Close();

            Console.WriteLine("Wrote the byte " + HexTextbox.Text + " at offset " + offset.ToString());
        }

        private void BRSTMOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Binary Revolution Stream (.brstm)|*.brstm";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                //BRSAROpenTextbox.Text = openDlg.SafeFileName;
                brstmPath = openDlg.FileName;
                BRSTMFileInfo();
                brstmfileloaded.Text = brstmPath;
            }
        }

        private void BRSTMFileInfo() 
        {

            //Find data about File
            FileInfo fi = new FileInfo(brstmPath);
            long filesize = fi.Length;

            BytesTextbox.Text = filesize.ToString();
            HexTextbox.Text = filesize.ToString("X6");

            if (filesize > 16777215) {
                MessageBox.Show("Warning brstm filesize may be too big i.e. greater than 16mb.");
            }

        }

        private void LoadMusicXml() {

            XElement tracks;

            try
            {
                tracks = XElement.Load(musicOffsetsPath);
            } 
            catch (Exception) 
            {
                MessageBox.Show("Error reading xml");
                this.Close();
                return;
            }
            MusicComboBox.Items.Clear();

            foreach (XElement child in tracks.Elements())
            {
                MusicTrack musicTrack = new MusicTrack();

                musicTrack.Title = child.Element("title").Value;
                musicTrack.Filename = child.Element("filename").Value;
                musicTrack.Offset = child.Element("offset").Value;

                musicTracks.Add(musicTrack);

                if (musicTrack.Title.Length > 0)
                {
                    MusicComboBox.Items.Add(musicTrack.Title + " (" + musicTrack.Filename.Replace(".brstm", "") + ")");
                }
                else 
                {
                    MusicComboBox.Items.Add(musicTrack.Filename.Replace(".brstm", ""));
                }                
            }

            MusicComboBox.SelectedIndexChanged += new EventHandler(MusicComboBox_Change); 

        }

        private void MusicComboBox_Change(Object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MusicComboBox, MusicComboBox.SelectedItem.ToString());
        }
        
    }
}
