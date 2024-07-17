namespace Guests_GuestApp
{
    partial class EnteranceForm
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
            label2 = new Label();
            button_OK = new Button();
            list_guests = new ListView();
            text_name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 36);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "ברוכים הבאים";
            // 
            // button_OK
            // 
            button_OK.Location = new Point(186, 447);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(115, 46);
            button_OK.TabIndex = 8;
            button_OK.Text = "אישור";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // list_guests
            // 
            list_guests.Location = new Point(152, 186);
            list_guests.Name = "list_guests";
            list_guests.RightToLeft = RightToLeft.Yes;
            list_guests.RightToLeftLayout = true;
            list_guests.Size = new Size(183, 230);
            list_guests.TabIndex = 7;
            list_guests.UseCompatibleStateImageBehavior = false;
            list_guests.View = View.List;
            // 
            // text_name
            // 
            text_name.Location = new Point(152, 136);
            text_name.Name = "text_name";
            text_name.RightToLeft = RightToLeft.Yes;
            text_name.Size = new Size(183, 27);
            text_name.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 95);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "הכנס שם אורח";
            // 
            // EnteranceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 569);
            Controls.Add(label2);
            Controls.Add(button_OK);
            Controls.Add(list_guests);
            Controls.Add(text_name);
            Controls.Add(label1);
            Name = "EnteranceForm";
            Text = "EnteranceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button_OK;
        private ListView list_guests;
        private TextBox text_name;
        private Label label1;
    }
}