namespace AutoSleep
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAction = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.radioButtonMiuntes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAction
            // 
            this.buttonAction.Enabled = false;
            this.buttonAction.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAction.Location = new System.Drawing.Point(67, 145);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(84, 36);
            this.buttonAction.TabIndex = 0;
            this.buttonAction.Text = "Sleep";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1297438037,
            893747220,
            18070036,
            1769472});
            this.numericUpDown1.Location = new System.Drawing.Point(130, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHours.Location = new System.Drawing.Point(26, 95);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(63, 22);
            this.radioButtonHours.TabIndex = 2;
            this.radioButtonHours.Text = "Hours";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonMiuntes
            // 
            this.radioButtonMiuntes.AutoSize = true;
            this.radioButtonMiuntes.Checked = true;
            this.radioButtonMiuntes.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMiuntes.Location = new System.Drawing.Point(26, 62);
            this.radioButtonMiuntes.Name = "radioButtonMiuntes";
            this.radioButtonMiuntes.Size = new System.Drawing.Size(76, 22);
            this.radioButtonMiuntes.TabIndex = 3;
            this.radioButtonMiuntes.TabStop = true;
            this.radioButtonMiuntes.Text = "Minutes";
            this.radioButtonMiuntes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "no Timer Set";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonMiuntes);
            this.Controls.Add(this.radioButtonHours);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAction);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sleep";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonMiuntes;
        private System.Windows.Forms.Label label1;
    }
}

