namespace WindowsFormsApp4
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
            this.question_text = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.solution_textbox = new System.Windows.Forms.TextBox();
            this.solution_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question_text
            // 
            this.question_text.Location = new System.Drawing.Point(105, 54);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(334, 56);
            this.question_text.TabIndex = 0;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button.Location = new System.Drawing.Point(492, 54);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(156, 43);
            this.button.TabIndex = 1;
            this.button.Text = "คำคม";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // solution_textbox
            // 
            this.solution_textbox.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution_textbox.ForeColor = System.Drawing.Color.IndianRed;
            this.solution_textbox.Location = new System.Drawing.Point(105, 138);
            this.solution_textbox.Multiline = true;
            this.solution_textbox.Name = "solution_textbox";
            this.solution_textbox.Size = new System.Drawing.Size(206, 51);
            this.solution_textbox.TabIndex = 2;
            this.solution_textbox.Text = "0";
            // 
            // solution_label
            // 
            this.solution_label.AutoSize = true;
            this.solution_label.BackColor = System.Drawing.SystemColors.Control;
            this.solution_label.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.solution_label.Location = new System.Drawing.Point(430, 141);
            this.solution_label.Name = "solution_label";
            this.solution_label.Size = new System.Drawing.Size(35, 48);
            this.solution_label.TabIndex = 3;
            this.solution_label.Text = "0";
            this.solution_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution_label);
            this.Controls.Add(this.solution_textbox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.question_text);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox solution_textbox;
        private System.Windows.Forms.Label solution_label;
    }
}

