namespace ToDoListApp
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.todoText = new System.Windows.Forms.TextBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.addUpdateTodo = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.Location = new System.Drawing.Point(36, 65);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(306, 329);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            this.todoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoListBox_KeyDown);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do List";
            // 
            // todoText
            // 
            this.todoText.Location = new System.Drawing.Point(464, 194);
            this.todoText.Name = "todoText";
            this.todoText.Size = new System.Drawing.Size(232, 20);
            this.todoText.TabIndex = 2;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(468, 175);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(82, 13);
            this.todoLabel.TabIndex = 3;
            this.todoLabel.Text = "New ToDo Item";
            // 
            // addUpdateTodo
            // 
            this.addUpdateTodo.Location = new System.Drawing.Point(466, 226);
            this.addUpdateTodo.Name = "addUpdateTodo";
            this.addUpdateTodo.Size = new System.Drawing.Size(229, 41);
            this.addUpdateTodo.TabIndex = 4;
            this.addUpdateTodo.Text = "Add ToDo Item";
            this.addUpdateTodo.UseVisualStyleBackColor = true;
            this.addUpdateTodo.Click += new System.EventHandler(this.addUpdateTodo_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(370, 172);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(62, 41);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(372, 242);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(59, 47);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 462);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.addUpdateTodo);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.todoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todoListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox todoText;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Button addUpdateTodo;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

