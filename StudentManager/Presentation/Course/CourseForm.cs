using StudentManager.DataAccess.Connection;
using StudentManager.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Presentation.Course
{
    public partial class CourseForm : Form
    {
        private AppDbContext? dbContext;

        public CourseForm()
        {
            InitializeComponent();
        }

        private void LoadInitial()
        {
            var data = this.dbContext.Courses.ToList();

            DgvCourseList.DataSource = data;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new AppDbContext();

            this.dbContext.Database.EnsureCreated();

            var data = this.dbContext.Courses.ToList();

            DgvCourseList.DataSource = data;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "Editar";
            editButton.Text = "Editar";
            editButton.UseColumnTextForButtonValue = true;
            DgvCourseList.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Eliminar";
            deleteButton.Text = "Eliminar";
            deleteButton.UseColumnTextForButtonValue = true;
            DgvCourseList.Columns.Add(deleteButton);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TxtName.Text;
                string description = TxtDescription.Text;
                int credit = int.Parse(TxtCredit.Text);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("El nombre es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtName.Focus();

                    return;
                }

                if (string.IsNullOrEmpty(TxtCredit.Text))
                {
                    MessageBox.Show("El correo es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCredit.Focus();

                    return;
                }

                var data = new CourseModel
                {
                    CourseName = name,
                    Description = description,
                    Credits = credit
                };

                this.dbContext.Add(data);
                this.dbContext.SaveChanges();
                LoadInitial();

                MessageBox.Show("Curso Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.Clear();
                TxtDescription.Clear();
                TxtCredit.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al momento de guardar Curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no sea el encabezado
            {
                if (DgvCourseList.Columns[e.ColumnIndex].Name == "Edit")
                {
                    try
                    {
                        var selectedRow = DgvCourseList.Rows[e.RowIndex];
                        string id = selectedRow.Cells["Id"].Value.ToString();
                        string name = selectedRow.Cells["CourseName"].Value.ToString();
                        string description = selectedRow.Cells["Description"].Value.ToString();
                        int credit = int.Parse(selectedRow.Cells["Credits"].Value.ToString() ?? "1");

                        var record = dbContext.Courses.FirstOrDefault(x => x.Id == int.Parse(id));

                        if (record != null)
                        {
                            //Modificamos el tipo de telefono, podriamos modificar cualquier campo...
                            record.CourseName = name;
                            record.Description = description;
                            record.Credits = credit;

                            // Guardamos los cambios en la BD
                            dbContext.SaveChanges();
                            MessageBox.Show("Curso editado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // No se encontro en la BD
                        }
;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al momento de editar Curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (DgvCourseList.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        var selectedRow = DgvCourseList.Rows[e.RowIndex];
                        string id = selectedRow.Cells["Id"].Value.ToString();

                        var record = dbContext.Courses.FirstOrDefault(x => x.Id == int.Parse(id));

                        if (record != null)
                        {
                            // Guardamos los cambios en la BD
                            dbContext.Courses.Remove(record);
                            dbContext.SaveChanges();
                            MessageBox.Show("Curso eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // No se encontro en la BD
                        }

                        LoadInitial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al momento de eliminar Curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
