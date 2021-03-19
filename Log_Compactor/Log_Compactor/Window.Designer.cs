namespace Log_Compactor
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Drop_Zone = new System.Windows.Forms.PictureBox();
            this.Text_Box_Original_Path = new System.Windows.Forms.TextBox();
            this.Track_Bar_Seperated_Part = new System.Windows.Forms.TrackBar();
            this.Label_Seperated_Part = new System.Windows.Forms.Label();
            this.Label_Chunk_Size = new System.Windows.Forms.Label();
            this.Track_Bar_Package_Size = new System.Windows.Forms.TrackBar();
            this.Button_Start = new System.Windows.Forms.PictureBox();
            this.Button_Browse = new System.Windows.Forms.PictureBox();
            this.Open_File_Dialog_1 = new System.Windows.Forms.OpenFileDialog();
            this.Label_Min_Length = new System.Windows.Forms.Label();
            this.Text_Box_Min_Length = new System.Windows.Forms.TextBox();
            this.Check_Box_Removed_Content = new System.Windows.Forms.CheckBox();
            this.Text_Box_Excluded_Entries = new System.Windows.Forms.RichTextBox();
            this.Button_Toggle_Exclusions = new System.Windows.Forms.PictureBox();
            this.Button_Reset_Blacklist = new System.Windows.Forms.PictureBox();
            this.Check_Box_Show_Menu_Battle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Zone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Seperated_Part)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Package_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Browse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Toggle_Exclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Reset_Blacklist)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop_Zone
            // 
            this.Drop_Zone.BackColor = System.Drawing.SystemColors.MenuText;
            this.Drop_Zone.Location = new System.Drawing.Point(-1, -1);
            this.Drop_Zone.Name = "Drop_Zone";
            this.Drop_Zone.Size = new System.Drawing.Size(430, 190);
            this.Drop_Zone.TabIndex = 1;
            this.Drop_Zone.TabStop = false;
            this.Drop_Zone.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drop_Zone_DragDrop);
            this.Drop_Zone.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_Zone_DragEnter);
            this.Drop_Zone.DragOver += new System.Windows.Forms.DragEventHandler(this.Drop_Zone_DragOver);
            // 
            // Text_Box_Original_Path
            // 
            this.Text_Box_Original_Path.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Text_Box_Original_Path.Font = new System.Drawing.Font("Georgia", 12F);
            this.Text_Box_Original_Path.Location = new System.Drawing.Point(31, 195);
            this.Text_Box_Original_Path.Name = "Text_Box_Original_Path";
            this.Text_Box_Original_Path.Size = new System.Drawing.Size(367, 26);
            this.Text_Box_Original_Path.TabIndex = 2;
            // 
            // Track_Bar_Seperated_Part
            // 
            this.Track_Bar_Seperated_Part.LargeChange = 1;
            this.Track_Bar_Seperated_Part.Location = new System.Drawing.Point(51, 344);
            this.Track_Bar_Seperated_Part.Maximum = 11;
            this.Track_Bar_Seperated_Part.Name = "Track_Bar_Seperated_Part";
            this.Track_Bar_Seperated_Part.Size = new System.Drawing.Size(300, 45);
            this.Track_Bar_Seperated_Part.TabIndex = 3;
            this.Track_Bar_Seperated_Part.Scroll += new System.EventHandler(this.Track_Bar_Seperated_Part_Scroll);
            // 
            // Label_Seperated_Part
            // 
            this.Label_Seperated_Part.AutoSize = true;
            this.Label_Seperated_Part.Font = new System.Drawing.Font("Georgia", 20F);
            this.Label_Seperated_Part.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_Seperated_Part.Location = new System.Drawing.Point(54, 310);
            this.Label_Seperated_Part.Name = "Label_Seperated_Part";
            this.Label_Seperated_Part.Size = new System.Drawing.Size(263, 31);
            this.Label_Seperated_Part.TabIndex = 4;
            this.Label_Seperated_Part.Text = "Don\'t slice into parts";
            // 
            // Label_Chunk_Size
            // 
            this.Label_Chunk_Size.AutoSize = true;
            this.Label_Chunk_Size.Font = new System.Drawing.Font("Georgia", 20F);
            this.Label_Chunk_Size.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_Chunk_Size.Location = new System.Drawing.Point(54, 228);
            this.Label_Chunk_Size.Name = "Label_Chunk_Size";
            this.Label_Chunk_Size.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Chunk_Size.Size = new System.Drawing.Size(155, 31);
            this.Label_Chunk_Size.TabIndex = 6;
            this.Label_Chunk_Size.Text = "Chunk Size ";
            // 
            // Track_Bar_Package_Size
            // 
            this.Track_Bar_Package_Size.LargeChange = 1;
            this.Track_Bar_Package_Size.Location = new System.Drawing.Point(51, 262);
            this.Track_Bar_Package_Size.Maximum = 9;
            this.Track_Bar_Package_Size.Name = "Track_Bar_Package_Size";
            this.Track_Bar_Package_Size.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Track_Bar_Package_Size.Size = new System.Drawing.Size(300, 45);
            this.Track_Bar_Package_Size.TabIndex = 5;
            this.Track_Bar_Package_Size.Scroll += new System.EventHandler(this.Track_Bar_Package_Size_Scroll);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Start.Location = new System.Drawing.Point(399, 193);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(30, 30);
            this.Button_Start.TabIndex = 7;
            this.Button_Start.TabStop = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            this.Button_Start.MouseLeave += new System.EventHandler(this.Button_Start_MouseLeave);
            this.Button_Start.MouseHover += new System.EventHandler(this.Button_Start_MouseHover);
            // 
            // Button_Browse
            // 
            this.Button_Browse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Browse.Location = new System.Drawing.Point(1, 193);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.Size = new System.Drawing.Size(30, 30);
            this.Button_Browse.TabIndex = 8;
            this.Button_Browse.TabStop = false;
            this.Button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            this.Button_Browse.MouseLeave += new System.EventHandler(this.Button_Browse_MouseLeave);
            this.Button_Browse.MouseHover += new System.EventHandler(this.Button_Browse_MouseHover);
            // 
            // Open_File_Dialog_1
            // 
            this.Open_File_Dialog_1.FileName = "Open_File_Dialog_1";
            // 
            // Label_Min_Length
            // 
            this.Label_Min_Length.AutoSize = true;
            this.Label_Min_Length.Font = new System.Drawing.Font("Georgia", 14F);
            this.Label_Min_Length.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_Min_Length.Location = new System.Drawing.Point(60, 474);
            this.Label_Min_Length.Name = "Label_Min_Length";
            this.Label_Min_Length.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Min_Length.Size = new System.Drawing.Size(160, 23);
            this.Label_Min_Length.TabIndex = 11;
            this.Label_Min_Length.Text = "Minimum Length";
            // 
            // Text_Box_Min_Length
            // 
            this.Text_Box_Min_Length.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Text_Box_Min_Length.Font = new System.Drawing.Font("Georgia", 12F);
            this.Text_Box_Min_Length.Location = new System.Drawing.Point(240, 471);
            this.Text_Box_Min_Length.Name = "Text_Box_Min_Length";
            this.Text_Box_Min_Length.Size = new System.Drawing.Size(51, 26);
            this.Text_Box_Min_Length.TabIndex = 12;
            // 
            // Check_Box_Removed_Content
            // 
            this.Check_Box_Removed_Content.AutoSize = true;
            this.Check_Box_Removed_Content.Font = new System.Drawing.Font("Georgia", 14F);
            this.Check_Box_Removed_Content.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Check_Box_Removed_Content.Location = new System.Drawing.Point(60, 438);
            this.Check_Box_Removed_Content.Name = "Check_Box_Removed_Content";
            this.Check_Box_Removed_Content.Size = new System.Drawing.Size(263, 27);
            this.Check_Box_Removed_Content.TabIndex = 13;
            this.Check_Box_Removed_Content.Text = "Create File of removed lines";
            this.Check_Box_Removed_Content.UseVisualStyleBackColor = true;
            // 
            // Text_Box_Excluded_Entries
            // 
            this.Text_Box_Excluded_Entries.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Text_Box_Excluded_Entries.Font = new System.Drawing.Font("Georgia", 13F);
            this.Text_Box_Excluded_Entries.Location = new System.Drawing.Point(31, 262);
            this.Text_Box_Excluded_Entries.Name = "Text_Box_Excluded_Entries";
            this.Text_Box_Excluded_Entries.Size = new System.Drawing.Size(367, 241);
            this.Text_Box_Excluded_Entries.TabIndex = 14;
            this.Text_Box_Excluded_Entries.Text = "";
            this.Text_Box_Excluded_Entries.Visible = false;
            // 
            // Button_Toggle_Exclusions
            // 
            this.Button_Toggle_Exclusions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Toggle_Exclusions.Location = new System.Drawing.Point(1, 486);
            this.Button_Toggle_Exclusions.Name = "Button_Toggle_Exclusions";
            this.Button_Toggle_Exclusions.Size = new System.Drawing.Size(30, 30);
            this.Button_Toggle_Exclusions.TabIndex = 15;
            this.Button_Toggle_Exclusions.TabStop = false;
            this.Button_Toggle_Exclusions.Click += new System.EventHandler(this.Button_Toggle_Exclusions_Click);
            this.Button_Toggle_Exclusions.MouseLeave += new System.EventHandler(this.Button_Toggle_Exclusions_MouseLeave);
            this.Button_Toggle_Exclusions.MouseHover += new System.EventHandler(this.Button_Toggle_Exclusions_MouseHover);
            // 
            // Button_Reset_Blacklist
            // 
            this.Button_Reset_Blacklist.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Reset_Blacklist.Location = new System.Drawing.Point(399, 486);
            this.Button_Reset_Blacklist.Name = "Button_Reset_Blacklist";
            this.Button_Reset_Blacklist.Size = new System.Drawing.Size(30, 30);
            this.Button_Reset_Blacklist.TabIndex = 16;
            this.Button_Reset_Blacklist.TabStop = false;
            this.Button_Reset_Blacklist.Click += new System.EventHandler(this.Button_Reset_Blacklist_Click);
            this.Button_Reset_Blacklist.MouseLeave += new System.EventHandler(this.Button_Reset_Blacklist_MouseLeave);
            this.Button_Reset_Blacklist.MouseHover += new System.EventHandler(this.Button_Reset_Blacklist_MouseHover);
            // 
            // Check_Box_Show_Menu_Battle
            // 
            this.Check_Box_Show_Menu_Battle.AutoSize = true;
            this.Check_Box_Show_Menu_Battle.Font = new System.Drawing.Font("Georgia", 14F);
            this.Check_Box_Show_Menu_Battle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Check_Box_Show_Menu_Battle.Location = new System.Drawing.Point(60, 405);
            this.Check_Box_Show_Menu_Battle.Name = "Check_Box_Show_Menu_Battle";
            this.Check_Box_Show_Menu_Battle.Size = new System.Drawing.Size(215, 27);
            this.Check_Box_Show_Menu_Battle.TabIndex = 17;
            this.Check_Box_Show_Menu_Battle.Text = "Skip Menu Battle Info";
            this.Check_Box_Show_Menu_Battle.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(428, 517);
            this.Controls.Add(this.Text_Box_Excluded_Entries);
            this.Controls.Add(this.Label_Chunk_Size);
            this.Controls.Add(this.Check_Box_Show_Menu_Battle);
            this.Controls.Add(this.Button_Reset_Blacklist);
            this.Controls.Add(this.Button_Toggle_Exclusions);
            this.Controls.Add(this.Check_Box_Removed_Content);
            this.Controls.Add(this.Text_Box_Min_Length);
            this.Controls.Add(this.Label_Min_Length);
            this.Controls.Add(this.Button_Browse);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Track_Bar_Package_Size);
            this.Controls.Add(this.Label_Seperated_Part);
            this.Controls.Add(this.Track_Bar_Seperated_Part);
            this.Controls.Add(this.Text_Box_Original_Path);
            this.Controls.Add(this.Drop_Zone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "Imperialware        EAW Log Compactor v0.4";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Zone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Seperated_Part)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Package_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Browse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Toggle_Exclusions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Reset_Blacklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Drop_Zone;
        private System.Windows.Forms.TextBox Text_Box_Original_Path;
        private System.Windows.Forms.TrackBar Track_Bar_Seperated_Part;
        private System.Windows.Forms.Label Label_Seperated_Part;
        private System.Windows.Forms.Label Label_Chunk_Size;
        private System.Windows.Forms.TrackBar Track_Bar_Package_Size;
        private System.Windows.Forms.PictureBox Button_Start;
        private System.Windows.Forms.PictureBox Button_Browse;
        private System.Windows.Forms.OpenFileDialog Open_File_Dialog_1;
        private System.Windows.Forms.Label Label_Min_Length;
        private System.Windows.Forms.TextBox Text_Box_Min_Length;
        private System.Windows.Forms.CheckBox Check_Box_Removed_Content;
        private System.Windows.Forms.RichTextBox Text_Box_Excluded_Entries;
        private System.Windows.Forms.PictureBox Button_Toggle_Exclusions;
        private System.Windows.Forms.PictureBox Button_Reset_Blacklist;
        private System.Windows.Forms.CheckBox Check_Box_Show_Menu_Battle;
    }
}

