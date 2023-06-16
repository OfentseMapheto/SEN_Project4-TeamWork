namespace Phenyo_Ditsi_WinDowsForms_VS
{
    partial class Contract
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelContractID = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.labelDurattion = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxContractID = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGenerateID = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCost);
            this.groupBox1.Controls.Add(this.textBoxDuration);
            this.groupBox1.Controls.Add(this.textBoxAvailability);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelAvailability);
            this.groupBox1.Controls.Add(this.labelDurattion);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contract Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonInsert);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 216);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelContractID
            // 
            this.labelContractID.AutoSize = true;
            this.labelContractID.Location = new System.Drawing.Point(6, 16);
            this.labelContractID.Name = "labelContractID";
            this.labelContractID.Size = new System.Drawing.Size(61, 13);
            this.labelContractID.TabIndex = 0;
            this.labelContractID.Text = "Contract ID";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(18, 19);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(18, 49);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(56, 13);
            this.labelAvailability.TabIndex = 2;
            this.labelAvailability.Text = "Availability";
            // 
            // labelDurattion
            // 
            this.labelDurattion.AutoSize = true;
            this.labelDurattion.Location = new System.Drawing.Point(18, 78);
            this.labelDurattion.Name = "labelDurattion";
            this.labelDurattion.Size = new System.Drawing.Size(47, 13);
            this.labelDurattion.TabIndex = 3;
            this.labelDurattion.Text = "Duration";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(18, 109);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Cost";
            // 
            // textBoxContractID
            // 
            this.textBoxContractID.Location = new System.Drawing.Point(100, 13);
            this.textBoxContractID.Name = "textBoxContractID";
            this.textBoxContractID.Size = new System.Drawing.Size(100, 20);
            this.textBoxContractID.TabIndex = 5;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(112, 16);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 6;
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Location = new System.Drawing.Point(112, 46);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvailability.TabIndex = 7;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(112, 75);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 8;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(112, 106);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 9;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(24, 180);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(128, 180);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(230, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonGenerateID
            // 
            this.buttonGenerateID.Location = new System.Drawing.Point(206, 13);
            this.buttonGenerateID.Name = "buttonGenerateID";
            this.buttonGenerateID.Size = new System.Drawing.Size(60, 20);
            this.buttonGenerateID.TabIndex = 5;
            this.buttonGenerateID.Text = "Generate";
            this.buttonGenerateID.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGenerateID);
            this.groupBox3.Controls.Add(this.labelContractID);
            this.groupBox3.Controls.Add(this.textBoxContractID);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 46);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Unique ID";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 268);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Contract";
            this.Text = "Contract";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxAvailability;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxContractID;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelDurattion;
        private System.Windows.Forms.Label labelContractID;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerateID;
    }
}