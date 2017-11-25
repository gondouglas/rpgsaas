namespace RpgSystem
{
    partial class frm_projectSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_projectSelect));
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nameProject = new System.Windows.Forms.Label();
            this.btn_createProject = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_user
            // 
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.Location = new System.Drawing.Point(23, 12);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(50, 50);
            this.pic_user.TabIndex = 0;
            this.pic_user.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.MaximumSize = new System.Drawing.Size(122, 251);
            this.listBox1.MinimumSize = new System.Drawing.Size(122, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 251);
            this.listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 329);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nameProject
            // 
            this.lbl_nameProject.AutoSize = true;
            this.lbl_nameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameProject.Location = new System.Drawing.Point(166, 12);
            this.lbl_nameProject.Name = "lbl_nameProject";
            this.lbl_nameProject.Size = new System.Drawing.Size(165, 42);
            this.lbl_nameProject.TabIndex = 5;
            this.lbl_nameProject.Text = "Project 1";
            // 
            // btn_createProject
            // 
            this.btn_createProject.Location = new System.Drawing.Point(12, 362);
            this.btn_createProject.Name = "btn_createProject";
            this.btn_createProject.Size = new System.Drawing.Size(122, 23);
            this.btn_createProject.TabIndex = 6;
            this.btn_createProject.Text = "Create project";
            this.btn_createProject.UseVisualStyleBackColor = true;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(450, 362);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(122, 23);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(322, 362);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_projectSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 414);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_createProject);
            this.Controls.Add(this.lbl_nameProject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_user);
            this.MaximumSize = new System.Drawing.Size(600, 453);
            this.MinimumSize = new System.Drawing.Size(600, 453);
            this.Name = "frm_projectSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rpg System";
            this.Load += new System.EventHandler(this.frm_projectSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nameProject;
        private System.Windows.Forms.Button btn_createProject;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
    }
}