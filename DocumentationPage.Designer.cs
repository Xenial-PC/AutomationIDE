
namespace AutomationIDE
{
    partial class DocumentationPage
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Scripting Options", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ClickBy Options", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("SendKeysBy Options", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("SubmitBy Options", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Util Options", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("--target");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("SubmitByXPath");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("SubmitByTagName");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("SubmitByName");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("SubmitById");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("SubmitByCssSelector");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("SubmitByClassName");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Sleep");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("SendKeysByXPath");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("SendKeysByTagName");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("SendKeysByName");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("SendKeysById");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("SendKeysByCssSelector");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("SendKeysByClassName");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Redirect");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("P:JScript");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("--noDispose");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Message");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("JScript");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("--hideCMD");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("--headless");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("--firefox");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("ClickByXPath");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("ClickByTagName");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("ClickByName");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("ClickById");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("ClickByCssSelector");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("ClickByClassName");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("--chrome");
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeywordsListBox = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentationInfoBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.KeywordsListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 413);
            this.panel1.TabIndex = 0;
            // 
            // KeywordsListBox
            // 
            this.KeywordsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeywordsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeywordsListBox.ForeColor = System.Drawing.SystemColors.Info;
            listViewGroup1.Header = "Scripting Options";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "ScriptingOptions";
            listViewGroup2.Header = "ClickBy Options";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "ClickByOptionsHeader";
            listViewGroup3.Header = "SendKeysBy Options";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "SendKeysByOptionsHeader";
            listViewGroup4.Header = "SubmitBy Options";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "SubmitByOptionsHeader";
            listViewGroup5.Header = "Util Options";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "Utilities Options";
            this.KeywordsListBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.KeywordsListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.KeywordsListBox.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.ToolTipText = "Sets the target webpage you want to automate";
            listViewItem2.Group = listViewGroup4;
            listViewItem3.Group = listViewGroup4;
            listViewItem4.Group = listViewGroup4;
            listViewItem5.Group = listViewGroup4;
            listViewItem6.Group = listViewGroup4;
            listViewItem7.Group = listViewGroup4;
            listViewItem8.Group = listViewGroup5;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            listViewItem11.Group = listViewGroup3;
            listViewItem12.Group = listViewGroup3;
            listViewItem13.Group = listViewGroup3;
            listViewItem14.Group = listViewGroup3;
            listViewItem15.Group = listViewGroup5;
            listViewItem16.Group = listViewGroup5;
            listViewItem17.Group = listViewGroup1;
            listViewItem18.Group = listViewGroup5;
            listViewItem19.Group = listViewGroup5;
            listViewItem20.Group = listViewGroup1;
            listViewItem21.Group = listViewGroup1;
            listViewItem22.Group = listViewGroup1;
            listViewItem23.Group = listViewGroup2;
            listViewItem24.Group = listViewGroup2;
            listViewItem25.Group = listViewGroup2;
            listViewItem26.Group = listViewGroup2;
            listViewItem27.Group = listViewGroup2;
            listViewItem28.Group = listViewGroup2;
            listViewItem29.Group = listViewGroup1;
            this.KeywordsListBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29});
            this.KeywordsListBox.Location = new System.Drawing.Point(3, 34);
            this.KeywordsListBox.MultiSelect = false;
            this.KeywordsListBox.Name = "KeywordsListBox";
            this.KeywordsListBox.ShowItemToolTips = true;
            this.KeywordsListBox.Size = new System.Drawing.Size(276, 373);
            this.KeywordsListBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.KeywordsListBox.TabIndex = 1;
            this.KeywordsListBox.TileSize = new System.Drawing.Size(168, 20);
            this.KeywordsListBox.UseCompatibleStateImageBehavior = false;
            this.KeywordsListBox.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keywords";
            // 
            // DocumentationInfoBox
            // 
            this.DocumentationInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocumentationInfoBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.DocumentationInfoBox.Location = new System.Drawing.Point(305, 13);
            this.DocumentationInfoBox.Name = "DocumentationInfoBox";
            this.DocumentationInfoBox.ReadOnly = true;
            this.DocumentationInfoBox.ShortcutsEnabled = false;
            this.DocumentationInfoBox.Size = new System.Drawing.Size(481, 412);
            this.DocumentationInfoBox.TabIndex = 1;
            this.DocumentationInfoBox.Text = "";
            // 
            // DocumentationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 437);
            this.Controls.Add(this.DocumentationInfoBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentationPage";
            this.ShowIcon = false;
            this.Text = "Documentation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView KeywordsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DocumentationInfoBox;
    }
}