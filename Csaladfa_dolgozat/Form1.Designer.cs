namespace Csaladfa_dolgozat
{
    partial class csaladfaForm
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
            this.FamilyView = new System.Windows.Forms.DataGridView();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.dateofbirthTextbox = new System.Windows.Forms.TextBox();
            this.placeofbirthTextbox = new System.Windows.Forms.TextBox();
            this.mothersnameTextbox = new System.Windows.Forms.TextBox();
            this.fathersnameTextbox = new System.Windows.Forms.TextBox();
            this.timeofdeathTextbox = new System.Windows.Forms.TextBox();
            this.placeofdeathTextbox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyView)).BeginInit();
            this.SuspendLayout();
            // 
            // FamilyView
            // 
            this.FamilyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FamilyView.Location = new System.Drawing.Point(12, 12);
            this.FamilyView.Name = "FamilyView";
            this.FamilyView.Size = new System.Drawing.Size(475, 426);
            this.FamilyView.TabIndex = 0;
            this.FamilyView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FamilyView_CellClick);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(493, 12);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(195, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // dateofbirthTextbox
            // 
            this.dateofbirthTextbox.Location = new System.Drawing.Point(493, 38);
            this.dateofbirthTextbox.Name = "dateofbirthTextbox";
            this.dateofbirthTextbox.Size = new System.Drawing.Size(195, 20);
            this.dateofbirthTextbox.TabIndex = 2;
            // 
            // placeofbirthTextbox
            // 
            this.placeofbirthTextbox.Location = new System.Drawing.Point(493, 64);
            this.placeofbirthTextbox.Name = "placeofbirthTextbox";
            this.placeofbirthTextbox.Size = new System.Drawing.Size(195, 20);
            this.placeofbirthTextbox.TabIndex = 3;
            // 
            // mothersnameTextbox
            // 
            this.mothersnameTextbox.Location = new System.Drawing.Point(493, 90);
            this.mothersnameTextbox.Name = "mothersnameTextbox";
            this.mothersnameTextbox.Size = new System.Drawing.Size(195, 20);
            this.mothersnameTextbox.TabIndex = 4;
            // 
            // fathersnameTextbox
            // 
            this.fathersnameTextbox.Location = new System.Drawing.Point(493, 116);
            this.fathersnameTextbox.Name = "fathersnameTextbox";
            this.fathersnameTextbox.Size = new System.Drawing.Size(195, 20);
            this.fathersnameTextbox.TabIndex = 5;
            // 
            // timeofdeathTextbox
            // 
            this.timeofdeathTextbox.Location = new System.Drawing.Point(493, 142);
            this.timeofdeathTextbox.Name = "timeofdeathTextbox";
            this.timeofdeathTextbox.Size = new System.Drawing.Size(195, 20);
            this.timeofdeathTextbox.TabIndex = 6;
            // 
            // placeofdeathTextbox
            // 
            this.placeofdeathTextbox.Location = new System.Drawing.Point(493, 168);
            this.placeofdeathTextbox.Name = "placeofdeathTextbox";
            this.placeofdeathTextbox.Size = new System.Drawing.Size(195, 20);
            this.placeofdeathTextbox.TabIndex = 7;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(493, 194);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // csaladfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.placeofdeathTextbox);
            this.Controls.Add(this.timeofdeathTextbox);
            this.Controls.Add(this.fathersnameTextbox);
            this.Controls.Add(this.mothersnameTextbox);
            this.Controls.Add(this.placeofbirthTextbox);
            this.Controls.Add(this.dateofbirthTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.FamilyView);
            this.Name = "csaladfaForm";
            this.Text = "csaladfa";
            this.Load += new System.EventHandler(this.csaladfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FamilyView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FamilyView;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox dateofbirthTextbox;
        private System.Windows.Forms.TextBox placeofbirthTextbox;
        private System.Windows.Forms.TextBox mothersnameTextbox;
        private System.Windows.Forms.TextBox fathersnameTextbox;
        private System.Windows.Forms.TextBox timeofdeathTextbox;
        private System.Windows.Forms.TextBox placeofdeathTextbox;
        private System.Windows.Forms.Button updateBtn;
    }
}

