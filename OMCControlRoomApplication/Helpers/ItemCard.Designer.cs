namespace OMCControlRoomApplication.Helpers
{
    partial class ItemCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lytMain = new System.Windows.Forms.TableLayoutPanel();
            this.lytInner_1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.lbl_04 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblLastActivity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnSubName = new System.Windows.Forms.Button();
            this.btnMainName = new System.Windows.Forms.Button();
            this.lytMain.SuspendLayout();
            this.lytInner_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lytMain
            // 
            this.lytMain.ColumnCount = 1;
            this.lytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lytMain.Controls.Add(this.lytInner_1, 0, 1);
            this.lytMain.Controls.Add(this.btnSubName, 0, 0);
            this.lytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytMain.Location = new System.Drawing.Point(0, 0);
            this.lytMain.Name = "lytMain";
            this.lytMain.RowCount = 2;
            this.lytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.lytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.lytMain.Size = new System.Drawing.Size(394, 191);
            this.lytMain.TabIndex = 0;
            this.lytMain.Visible = false;
            // 
            // lytInner_1
            // 
            this.lytInner_1.ColumnCount = 4;
            this.lytInner_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytInner_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.lytInner_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytInner_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.lytInner_1.Controls.Add(this.label2, 0, 2);
            this.lytInner_1.Controls.Add(this.lbl_03, 0, 1);
            this.lytInner_1.Controls.Add(this.lbl_01, 0, 0);
            this.lytInner_1.Controls.Add(this.lbl_02, 2, 0);
            this.lytInner_1.Controls.Add(this.lbl_04, 2, 1);
            this.lytInner_1.Controls.Add(this.label1, 2, 2);
            this.lytInner_1.Controls.Add(this.lblCity, 1, 0);
            this.lytInner_1.Controls.Add(this.lblProject, 1, 1);
            this.lytInner_1.Controls.Add(this.lblLastActivity, 1, 2);
            this.lytInner_1.Controls.Add(this.lblStatus, 3, 2);
            this.lytInner_1.Controls.Add(this.lblType, 3, 0);
            this.lytInner_1.Controls.Add(this.btnMap, 3, 1);
            this.lytInner_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytInner_1.Location = new System.Drawing.Point(3, 79);
            this.lytInner_1.Name = "lytInner_1";
            this.lytInner_1.RowCount = 3;
            this.lytInner_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lytInner_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lytInner_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lytInner_1.Size = new System.Drawing.Size(388, 109);
            this.lytInner_1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Activity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_03
            // 
            this.lbl_03.AutoSize = true;
            this.lbl_03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_03.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_03.Location = new System.Drawing.Point(3, 36);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Size = new System.Drawing.Size(71, 36);
            this.lbl_03.TabIndex = 2;
            this.lbl_03.Text = "Project";
            this.lbl_03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_01.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_01.Location = new System.Drawing.Point(3, 0);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(71, 36);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "City";
            this.lbl_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_02.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_02.Location = new System.Drawing.Point(196, 0);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(71, 36);
            this.lbl_02.TabIndex = 1;
            this.lbl_02.Text = "Type";
            this.lbl_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_04
            // 
            this.lbl_04.AutoSize = true;
            this.lbl_04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_04.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_04.Location = new System.Drawing.Point(196, 36);
            this.lbl_04.Name = "lbl_04";
            this.lbl_04.Size = new System.Drawing.Size(71, 36);
            this.lbl_04.TabIndex = 3;
            this.lbl_04.Text = "Location";
            this.lbl_04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(196, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCity.Location = new System.Drawing.Point(80, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(110, 36);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "label3";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProject.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblProject.Location = new System.Drawing.Point(80, 36);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(110, 36);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "label3";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastActivity
            // 
            this.lblLastActivity.AutoSize = true;
            this.lblLastActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastActivity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblLastActivity.Location = new System.Drawing.Point(80, 72);
            this.lblLastActivity.Name = "lblLastActivity";
            this.lblLastActivity.Size = new System.Drawing.Size(110, 37);
            this.lblLastActivity.TabIndex = 6;
            this.lblLastActivity.Text = "label3";
            this.lblLastActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(273, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 37);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "label3";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(273, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(112, 36);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "label3";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMap
            // 
            this.btnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMap.Location = new System.Drawing.Point(273, 39);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(112, 30);
            this.btnMap.TabIndex = 7;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            // 
            // btnSubName
            // 
            this.btnSubName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubName.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSubName.Location = new System.Drawing.Point(3, 3);
            this.btnSubName.Name = "btnSubName";
            this.btnSubName.Size = new System.Drawing.Size(388, 70);
            this.btnSubName.TabIndex = 1;
            this.btnSubName.Text = "CODE";
            this.btnSubName.UseVisualStyleBackColor = true;
            this.btnSubName.Click += new System.EventHandler(this.ToggleDetails_Click);
            // 
            // btnMainName
            // 
            this.btnMainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainName.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.btnMainName.Location = new System.Drawing.Point(0, 0);
            this.btnMainName.Name = "btnMainName";
            this.btnMainName.Size = new System.Drawing.Size(394, 191);
            this.btnMainName.TabIndex = 0;
            this.btnMainName.Text = "button2";
            this.btnMainName.UseVisualStyleBackColor = true;
            this.btnMainName.Click += new System.EventHandler(this.ToggleDetails_Click);
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lytMain);
            this.Controls.Add(this.btnMainName);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(394, 191);
            this.lytMain.ResumeLayout(false);
            this.lytInner_1.ResumeLayout(false);
            this.lytInner_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lytMain;
        private System.Windows.Forms.TableLayoutPanel lytInner_1;
        private System.Windows.Forms.Button btnSubName;
        private System.Windows.Forms.Label lbl_04;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Button btnMainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblLastActivity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnMap;
    }
}
