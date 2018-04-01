namespace VelibClientWinform
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchStation = new System.Windows.Forms.Button();
            this.stationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stationName = new System.Windows.Forms.TextBox();
            this.bikeNum = new System.Windows.Forms.TextBox();
            this.SearchBike = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.contractBox = new System.Windows.Forms.TextBox();
            this.searchContract = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(94, 146);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stations:";
            // 
            // SearchStation
            // 
            this.SearchStation.Location = new System.Drawing.Point(228, 144);
            this.SearchStation.Name = "SearchStation";
            this.SearchStation.Size = new System.Drawing.Size(75, 23);
            this.SearchStation.TabIndex = 5;
            this.SearchStation.Text = "Search";
            this.SearchStation.UseVisualStyleBackColor = true;
            this.SearchStation.Click += new System.EventHandler(this.SearchStation_Click);
            // 
            // stationBox
            // 
            this.stationBox.Location = new System.Drawing.Point(43, 223);
            this.stationBox.Multiline = true;
            this.stationBox.Name = "stationBox";
            this.stationBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stationBox.Size = new System.Drawing.Size(234, 186);
            this.stationBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Station:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available Bikes:";
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(452, 146);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(141, 20);
            this.stationName.TabIndex = 9;
            // 
            // bikeNum
            // 
            this.bikeNum.Location = new System.Drawing.Point(490, 184);
            this.bikeNum.Name = "bikeNum";
            this.bikeNum.Size = new System.Drawing.Size(103, 20);
            this.bikeNum.TabIndex = 10;
            // 
            // SearchBike
            // 
            this.SearchBike.Location = new System.Drawing.Point(621, 139);
            this.SearchBike.Name = "SearchBike";
            this.SearchBike.Size = new System.Drawing.Size(75, 23);
            this.SearchBike.TabIndex = 11;
            this.SearchBike.Text = "Search";
            this.SearchBike.UseVisualStyleBackColor = true;
            this.SearchBike.Click += new System.EventHandler(this.SearchBike_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contract:";
            // 
            // contractBox
            // 
            this.contractBox.Location = new System.Drawing.Point(94, 55);
            this.contractBox.Multiline = true;
            this.contractBox.Name = "contractBox";
            this.contractBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contractBox.Size = new System.Drawing.Size(499, 57);
            this.contractBox.TabIndex = 14;
            // 
            // searchContract
            // 
            this.searchContract.Location = new System.Drawing.Point(621, 53);
            this.searchContract.Name = "searchContract";
            this.searchContract.Size = new System.Drawing.Size(75, 23);
            this.searchContract.TabIndex = 15;
            this.searchContract.Text = "Search";
            this.searchContract.UseVisualStyleBackColor = true;
            this.searchContract.Click += new System.EventHandler(this.searchContract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 446);
            this.Controls.Add(this.searchContract);
            this.Controls.Add(this.contractBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchBike);
            this.Controls.Add(this.bikeNum);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stationBox);
            this.Controls.Add(this.SearchStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchStation;
        private System.Windows.Forms.TextBox stationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.TextBox bikeNum;
        private System.Windows.Forms.Button SearchBike;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contractBox;
        private System.Windows.Forms.Button searchContract;
    }
}

