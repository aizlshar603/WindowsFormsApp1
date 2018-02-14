namespace WindowsFormsApp1
{
    partial class springfield
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reactor2 = new System.Windows.Forms.Label();
            this.reactor1 = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.state2label = new System.Windows.Forms.Label();
            this.state1label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(39, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(295, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Springfield Nuclear Power Plant";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 18);
            this.label2.TabIndex = 1;
            // 
            // reactor2
            // 
            this.reactor2.AutoSize = true;
            this.reactor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reactor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reactor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2.Location = new System.Drawing.Point(236, 85);
            this.reactor2.Name = "reactor2";
            this.reactor2.Size = new System.Drawing.Size(68, 19);
            this.reactor2.TabIndex = 2;
            this.reactor2.Text = "Reactor2";
            // 
            // reactor1
            // 
            this.reactor1.AutoSize = true;
            this.reactor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reactor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reactor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1.Location = new System.Drawing.Point(68, 85);
            this.reactor1.Name = "reactor1";
            this.reactor1.Size = new System.Drawing.Size(68, 19);
            this.reactor1.TabIndex = 3;
            this.reactor1.Text = "Reactor1";
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.SystemColors.Control;
            this.enableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.enableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.enableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableButton.Location = new System.Drawing.Point(83, 205);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(190, 23);
            this.enableButton.TabIndex = 4;
            this.enableButton.Text = "Enable Button";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // state2label
            // 
            this.state2label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.state2label.Location = new System.Drawing.Point(68, 118);
            this.state2label.Name = "state2label";
            this.state2label.Size = new System.Drawing.Size(68, 84);
            this.state2label.TabIndex = 5;
         
            // 
            // state1label
            // 
            this.state1label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.state1label.Location = new System.Drawing.Point(236, 118);
            this.state1label.Name = "state1label";
            this.state1label.Size = new System.Drawing.Size(68, 84);
            this.state1label.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(156, 237);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(57, 15);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "All is good";
            // 
            // springfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.state1label);
            this.Controls.Add(this.state2label);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.reactor1);
            this.Controls.Add(this.reactor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "springfield";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reactor2;
        private System.Windows.Forms.Label reactor1;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Label state2label;
        private System.Windows.Forms.Label state1label;
        private System.Windows.Forms.Label outputLabel;
    }
}

