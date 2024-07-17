namespace Guests_GuestApp
{
    partial class CategoryForm
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
            table = new DataGridView();
            button_add = new Button();
            text_food = new TextBox();
            button_next = new Button();
            button_previous = new Button();
            label_category = new Label();
            list_myfood = new ListView();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(32, 85);
            table.Name = "table";
            table.RightToLeft = RightToLeft.Yes;
            table.RowHeadersWidth = 51;
            table.Size = new Size(436, 188);
            table.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(374, 289);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 3;
            button_add.Text = "הוסף מאכל";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // text_food
            // 
            text_food.Location = new Point(32, 290);
            text_food.Name = "text_food";
            text_food.RightToLeft = RightToLeft.Yes;
            text_food.Size = new Size(336, 27);
            text_food.TabIndex = 4;
            // 
            // button_next
            // 
            button_next.Location = new Point(132, 555);
            button_next.Name = "button_next";
            button_next.Size = new Size(94, 29);
            button_next.TabIndex = 5;
            button_next.Text = "<<<";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(274, 555);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(94, 29);
            button_previous.TabIndex = 6;
            button_previous.Text = ">>>";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Location = new Point(193, 47);
            label_category.Name = "label_category";
            label_category.Size = new Size(98, 20);
            label_category.TabIndex = 7;
            label_category.Text = "שם הקטגוריה";
            // 
            // list_myfood
            // 
            list_myfood.Location = new Point(32, 334);
            list_myfood.Name = "list_myfood";
            list_myfood.RightToLeft = RightToLeft.Yes;
            list_myfood.RightToLeftLayout = true;
            list_myfood.Size = new Size(436, 201);
            list_myfood.TabIndex = 8;
            list_myfood.UseCompatibleStateImageBehavior = false;
            list_myfood.View = View.List;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 638);
            Controls.Add(list_myfood);
            Controls.Add(label_category);
            Controls.Add(button_previous);
            Controls.Add(button_next);
            Controls.Add(text_food);
            Controls.Add(button_add);
            Controls.Add(table);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table;
        private Button button_add;
        private TextBox text_food;
        private Button button_next;
        private Button button_previous;
        private Label label_category;
        private ListView list_myfood;
    }
}