using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


// ====================================================================================================
// **************************************** 03.2021 Imperial ******************************************
// ====================================================================================================



namespace Log_Compactor
{


    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }



        string Excluded_Content = "";

        private void Window_Load(object sender, EventArgs e)
        {
            Drop_Zone.AllowDrop = true;
            Set_Resource_Button(Drop_Zone, Get_Start_Image());
            Set_Resource_Button(Button_Browse, Properties.Resources.Button_File);
            Set_Resource_Button(Button_Start, Properties.Resources.Button_Run);
            Set_Resource_Button(Button_Toggle_Exclusions, Properties.Resources.Button_Settings);
            Set_Resource_Button(Button_Reset_Blacklist, Properties.Resources.Button_Refresh);

            Button_Browse.BackColor = Color.Transparent;
            Button_Start.BackColor = Color.Transparent;
            Button_Reset_Blacklist.BackColor = Color.Transparent;
            Button_Toggle_Exclusions.BackColor = Color.Transparent;
    
     


            // Loading Values
            Text_Box_Original_Path.Text = Properties.Settings.Default.Last_File;
            Track_Bar_Seperated_Part.Value = Properties.Settings.Default.Passage;
            Track_Bar_Package_Size.Value = Properties.Settings.Default.Chunk_Size;
            Text_Box_Min_Length.Text = Properties.Settings.Default.Minimum_Length;
            Check_Box_Removed_Content.Checked = Properties.Settings.Default.Create_Removed_File;
            Check_Box_Show_Menu_Battle.Checked = Properties.Settings.Default.Skip_Menu_Battle;


            Excluded_Content = Properties.Settings.Default.Excluded_Entries;
            if (Excluded_Content == null | Excluded_Content == "") { Reset_Exclusion_List(); }


            Track_Bar_Package_Size_Scroll(null, null); // Updating Text
            Track_Bar_Seperated_Part_Scroll(null, null);

            Text_Box_Excluded_Entries.Text = Excluded_Content;

        }





        //-----------------------------------------------------------------------------
        // Enabling Drag and Drop
        //-----------------------------------------------------------------------------

        // Don't forget about Drag_And_Drop_Area.AllowDrop = true; in the constructor!
        private void Drop_Zone_DragDrop(object sender, DragEventArgs e)
        {
            var Data = e.Data.GetData(DataFormats.FileDrop);
            if (Data != null)
            {
                var File_Names = Data as string[];
                if (File_Names.Length > 0)
                {
                    // string Image_Name = Path.GetFileName(File_Names[0]);                    
                    try // Just to be on the safe side
                    {
                        string Template = File_Names[0];
                        if (!System.Text.RegularExpressions.Regex.IsMatch(Template, "(?i).*?" + ".txt$"))
                        { MessageBox.Show("Error: the Log file needs to be of .txt format."); }

                        else { Text_Box_Original_Path.Text = File_Names[0]; Chop_File(); }
                    } catch {}
                }
            }

        }

        private void Drop_Zone_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; // This means the dragged Map images        
        }

        private void Drop_Zone_DragOver(object sender, DragEventArgs e)
        { e.Effect = DragDropEffects.Move; }


        //===========================//

        private void Track_Bar_Package_Size_Scroll(object sender, EventArgs e)
        {
            Track_Bar_Seperated_Part.Maximum = 10 - Track_Bar_Package_Size.Value;

            if (Track_Bar_Package_Size.Value == 9)
            {
                Label_Chunk_Size.Text = "Chunk Size: Full";
                Label_Seperated_Part.Text = "Don't slice into parts";
                Track_Bar_Seperated_Part.Value = 0;
            }
            else { Label_Chunk_Size.Text = "Chunk Size: " + (10 - Track_Bar_Package_Size.Value).ToString(); }

        }

        private void Track_Bar_Seperated_Part_Scroll(object sender, EventArgs e)
        {
            if (Track_Bar_Seperated_Part.Value == 0) { Label_Seperated_Part.Text = "Don't slice into parts"; }
            else { Label_Seperated_Part.Text = "Compact only part: " + Track_Bar_Seperated_Part.Value.ToString(); }
        }



        //===========================//
        private void Button_Browse_Click(object sender, EventArgs e)
        {
            Open_File_Dialog_1.FileName = "";
            if (Properties.Settings.Default.Last_File != null & Properties.Settings.Default.Last_File != "")
            { Open_File_Dialog_1.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.Last_File); }      

            Open_File_Dialog_1.Filter = "vmt files (*.vmt)|*.vmt|Text files (*.txt)|*.txt";
            //Open_File_Dialog_1.FilterIndex = 1;
            //Open_File_Dialog_1.RestoreDirectory = true;
            //Open_File_Dialog_1.CheckFileExists = true;
            //Open_File_Dialog_1.CheckPathExists = true;

            try
            {   // If the Open Dialog found a File
                if (Open_File_Dialog_1.ShowDialog() == DialogResult.OK)
                { Text_Box_Original_Path.Text = Open_File_Dialog_1.FileName; }
            }  catch {}
        }

        private void Button_Browse_MouseHover(object sender, EventArgs e)
        { Set_Resource_Button(Button_Browse, Properties.Resources.Button_File); }

        private void Button_Browse_MouseLeave(object sender, EventArgs e)
        { Set_Resource_Button(Button_Browse, Properties.Resources.Button_File_Lit); }


        //===========================//
        private void Button_Start_Click(object sender, EventArgs e)
        { if (Text_Box_Original_Path.Text != "") { Chop_File(); }  }

        private void Button_Start_MouseHover(object sender, EventArgs e)
        { Set_Resource_Button(Button_Start, Properties.Resources.Button_Run_Lit); }

        private void Button_Start_MouseLeave(object sender, EventArgs e)
        { Set_Resource_Button(Button_Start, Properties.Resources.Button_Run); }


        //===========================//
        private void Button_Toggle_Exclusions_Click(object sender, EventArgs e)
        {
            if (Text_Box_Excluded_Entries.Visible == true)
            {
                Text_Box_Excluded_Entries.Visible = false;
                Label_Chunk_Size.Text = "Chunk Size";
                return;
            }
            else
            {   Text_Box_Excluded_Entries.Visible = true;
                Label_Chunk_Size.Text = "Excluded Entries";
                Text_Box_Excluded_Entries.Focus(); // So the user can scroll
                return;
            }
        }


        private void Button_Toggle_Exclusions_MouseHover(object sender, EventArgs e)
        { Set_Resource_Button(Button_Toggle_Exclusions, Properties.Resources.Button_Settings_Lit); }

        private void Button_Toggle_Exclusions_MouseLeave(object sender, EventArgs e)
        { Set_Resource_Button(Button_Toggle_Exclusions, Properties.Resources.Button_Settings); }


        //===========================//
        private void Button_Reset_Blacklist_Click(object sender, EventArgs e)
        { 
            Reset_Exclusion_List(); 
            Text_Box_Excluded_Entries.Text = Excluded_Content;
            if (Text_Box_Excluded_Entries.Visible == false) 
            { Text_Box_Excluded_Entries.Visible = true; }
            MessageBox.Show("Resetted Excluded Lines.");
        }

        private void Button_Reset_Blacklist_MouseHover(object sender, EventArgs e)
        { Set_Resource_Button(Button_Reset_Blacklist, Properties.Resources.Button_Refresh_Lit); }

        private void Button_Reset_Blacklist_MouseLeave(object sender, EventArgs e)
        { Set_Resource_Button(Button_Reset_Blacklist, Properties.Resources.Button_Refresh); }




        //-----------------------------------------------------------------------------
        // Main Function
        //-----------------------------------------------------------------------------
        private void Chop_File()
        {
            Set_Resource_Button(Drop_Zone, Get_Start_Image());
            List<string> Output_File = new List<string> { };
            List<string> Removed_Content = new List<string> { };

            int Line_Count = 0;
            int Minimum_Length = 30;
            Int32.TryParse(Text_Box_Min_Length.Text, out Minimum_Length);

            int Start_At = 56; // Skip the Petroglyph text headers 
            string Source_File = Text_Box_Original_Path.Text; 
            string Line = "";
            bool Include = false;
            bool Show_Removed = Check_Box_Removed_Content.Checked;

          

            //string Exclude_File = "Excluded_Lines.txt";
            //if (!File.Exists(Exclude_File)) { File.WriteAllText(Exclude_File, Excluded_Content); }
            //string[] Excluded_Phrases = File.ReadAllLines(Exclude_File); 




            string[] Excluded_Phrases = Text_Box_Excluded_Entries.Text.Split('\n'); 
            if (!Source_File.EndsWith(".txt")) { MessageBox.Show("The selected file needs to be a .txt log."); return; }
          
            
            Properties.Settings.Default.Last_File = Source_File;
            Properties.Settings.Default.Passage = Track_Bar_Seperated_Part.Value;
            Properties.Settings.Default.Chunk_Size = Track_Bar_Package_Size.Value;       
            Properties.Settings.Default.Minimum_Length = Minimum_Length.ToString();
            Properties.Settings.Default.Create_Removed_File = Check_Box_Removed_Content.Checked;
            Properties.Settings.Default.Skip_Menu_Battle = Check_Box_Show_Menu_Battle.Checked;
            if (Excluded_Content != Text_Box_Excluded_Entries.Text) // Then needs to update
            { Properties.Settings.Default.Excluded_Entries = Text_Box_Excluded_Entries.Text; }

            Properties.Settings.Default.Save();


            string[] Content_Lines = File.ReadAllLines(Source_File);
            int Column_Size = Content_Lines.Count();
                      


            if (Track_Bar_Seperated_Part.Value > 0)
            {              
                Column_Size = Column_Size / (10 - Track_Bar_Package_Size.Value);

                if (Track_Bar_Seperated_Part.Value > 1) { Start_At = 0; } // Because its just supposed to leap over the top header
                Start_At += Column_Size * (Track_Bar_Seperated_Part.Value -1); // -1 is important here 
                // Label_Chunk_Size.Text = "Column = " + Column_Size + " Size = " + (10 - Track_Bar_Package_Size.Value) + " Start = " + Start_At.ToString(); 
            }
        
  


           
            for (int i = Start_At; i < Content_Lines.Count(); i++)
            {            
                Include = true;
                Line_Count++;

                foreach (string Phrase in Excluded_Phrases)
                {
                    if (Phrase.StartsWith("//") || Phrase.StartsWith("#") || Phrase == "") { continue; } // Skip commented Lines
                    Line = Content_Lines[i];
                    if (Line == "" | Line == "#" | Line.Contains(Phrase) | Line.Length < Minimum_Length) { Include = false; break; } // Move on to the next Line                                                    
                }

                if (Include && Line.Count() > Minimum_Length) // If this cycle passed to the very last check
                {
                    if (Line.StartsWith("[")) // Get rid of the first 41 characters, thats the stack info
                    {   Line = Line.Substring(41, Line.Length - 41);
                        
                        if (Line.Length < Minimum_Length + 1) 
                        {   if (Show_Removed) { Removed_Content.Add(Line); }
                            continue; // Ignore lines that are too short
                        } 
                    }

                    if (Line.Contains("Parse_Database_Entry")) // Don't use "Unprocessed" cause that removes prefix of unintended errors.
                    { Line = Line.Substring(Line.IndexOf("Unprocessed"), Line.Length - Line.IndexOf("Unprocessed")); }

                    else if (Line.Contains("Fixup"))
                    { Line = Line.Substring(Line.IndexOf("Fixup"), Line.Length - Line.IndexOf("Fixup")); }



                    if (!Output_File.Contains(Line)) { Output_File.Add(Line); }
                    else if (Show_Removed) { Removed_Content.Add(Line); }                                
                }
                else if (Show_Removed) { Removed_Content.Add(Line); }


                if (Line_Count > Start_At + Column_Size | Check_Box_Show_Menu_Battle.Checked & Line.Contains("engine audio idle loop"))
                {   // Label_Chunk_Size.Text += " End = " + (Start_At + Column_Size); // Debug "Starting engine audio idle loop"
                    break; 
                }
           
            }






            File.WriteAllText(
                Path.GetDirectoryName(Source_File) + @"\"
                + Path.GetFileNameWithoutExtension(Source_File) + "_Chopped.txt", string.Join("\n", Output_File));


            if (Show_Removed)
            {  File.WriteAllText(
                    Path.GetDirectoryName(Source_File) + @"\"
                    + Path.GetFileNameWithoutExtension(Source_File) + "_Removed.txt", string.Join("\n", Removed_Content));                                    
            }


            Set_Resource_Button(Drop_Zone, Get_Compacted_Image()); // Changing Image
            
        }

      

        //-----------------------------------------------------------------------------
        // 
        //-----------------------------------------------------------------------------
     
        public void Set_Resource_Button(PictureBox The_Button, Bitmap Resource_Button, int Scale_Treshold = 0)
        {
            try { The_Button.BackgroundImage = Resize_Resource_Image(Resource_Button, The_Button.Size.Width + Scale_Treshold, The_Button.Size.Height + Scale_Treshold); }  catch { }
        }


        //===========================//

        public static Image Resize_Resource_Image(Bitmap image, int new_width, int new_height)
        {
            try
            {
                Bitmap new_image = new Bitmap(new_width, new_height);
                Graphics Picture = Graphics.FromImage((Image)new_image);
                Picture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                Picture.DrawImage(image, 0, 0, new_width, new_height);
                return new_image;
            }
            catch { }
            return null;
        }
        //===========================//
    

        public char[] Append(char[] x, char[] y)
        {
            if (x == null | y == null) { return null; }
            char[] z = new char[x.Length + y.Length];

            int j = 0;
            for (int i = 0; i < (x.Length + y.Length); i++)  // to combine two arrays
            {
                if (i < x.Length) { z[i] = x[i]; }
                else
                {
                    z[i] = y[j];
                    j = j + 1;
                }
            }

            return z;     
        }
        //===========================//

        public bool Char_Starts_With(char[] x, char y)
        {   if (x[0] == y) { return true; }
            return false;
        }


        //===========================//
        public Bitmap Get_Start_Image()
        {        
            Bitmap Result = null;

            if (Properties.Settings.Default.Star_Wars_Theme == false)
            {  return Properties.Resources.Shadow_Clone_01; }
            else {  return Properties.Resources.Starting_01; }
              
        }

        //===========================//


        public Bitmap Get_Compacted_Image()
        {
           Bitmap Result = null;
           Random rnd = new Random();
           int Value = rnd.Next(1, 2);  // creates a number between 1 and 4

            if (Properties.Settings.Default.Star_Wars_Theme == false)
            {                                          
                // Otherwise return a Star Wars based image:
                switch (Value)
                {
                    case 1:
                        Result = Properties.Resources.Rasengan_01;
                        break;
                    case 2:
                        Result = Properties.Resources.Shadow_Clone_02;
                        break;                

                    default:
                        Result = Properties.Resources.Rasengan_01;
                        break;
                }

                return Result;
            }



            Value = rnd.Next(1, 4);  // creates a number between 1 and 4
            
            // Otherwise return a Star Wars based image:
            switch (Value)
            {
                case 1:
                    Result = Properties.Resources.Compacted_01;
                    break;
                case 2:
                    Result = Properties.Resources.Compacted_02;
                    break;
                case 3:
                    Result = Properties.Resources.Compacted_03;
                    break;
                case 4:
                    Result = Properties.Resources.Compacted_04;
                    break;

                default:
                    Result = Properties.Resources.Compacted_01;
                    break;
            }

            return Result;

        }


        //===========================//
        public void Reset_Exclusion_List()
        {
            Excluded_Content = @"// I am a Comment # too
CRC:
Program:
00 Root
validated
Console Command
SteamClass
MegaFile
DefaultLangID
alD3dEffect::Load
Supported language
Creating cursors
Creating game objects
Creating SFXEvents
Creating new
Created new
Adding file
xmlParseFile
SFX event
Duplicate SFXEvent
Parsing found map
Added player
towards
can fire
firepower
is on team
Frame Advance to
WM_IME_SETCONTEXT
";
        }
       
    
        //===========================//



    }
}
