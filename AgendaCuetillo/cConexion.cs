﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics.Contracts;
using System.Data;
using System.Windows.Forms;

namespace AgendaCuetillo
{
    public class cConexion
    {
        //SqlConnection conex = new SqlConnection();      
        //static string servidor = "localhost";
        //static string DB = "DBAgenda";
        //static string user = "Agenda";
        //static string password = "726965602016";
        //static string puerto = "1433";

        //string cadenaConexion = "Data source=" + servidor + "," + puerto + ";" + "user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + DB + ";" + "Persist Security Info=true";

        protected OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBAgenda.accdb");

        //public SqlConnection establecerconexion()
        //{
        //    try
        //    {
        //        conex.ConnectionString = cadenaConexion;
        //        conex.Open();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show("No se logro conectar a la DB");
        //    }
        //    return conex;
        //}

        public OleDbConnection conexionBD()
        {
            try
            {               
                conexion.Open();
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la DB");
            }
            return conexion;
        }

        public OleDbConnection close()
        {
            try
            {
                conexion.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro cerrar la conexion");
            }
            return conexion;
        }

        public OleDbConnection IngresarDatos(cContacto contacto)
        {
            try
            {
                conexionBD();
                string query = "INSERT INTO TContactos (DNI, Nombre, ApellidoPaterno, ApellidoMaterno, Genero, Telefono, Email, Direccion, Nacimiento) VALUES (@dni, @nombre, @paterno, @materno, @genero, @telefono, @email, @direccion, @nacimiento)";
                OleDbCommand command = new OleDbCommand(query, conexion);
                command.Parameters.AddWithValue("@dni", contacto.DNI);
                command.Parameters.AddWithValue("@nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@paterno", contacto.ApellPaterno);
                command.Parameters.AddWithValue("@materno", contacto.ApellMaterno);
                command.Parameters.AddWithValue("@genero", contacto.Genero);
                command.Parameters.AddWithValue("@telefono", contacto.Telefono);
                command.Parameters.AddWithValue("@email", contacto.Email);
                command.Parameters.AddWithValue("@direccion", contacto.Direccion);
                command.Parameters.AddWithValue("@nacimiento", contacto.Nacimiento);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro ingresar contacto a la DB");
                close();
            }
            
            return conexion;
        }
        public OleDbConnection ModificarDatos(cContacto contacto, int i)
        {
            try
            {
                conexionBD();
                string query = "UPDATE TContactos SET DNI = @dni , Nombre = @nombre, ApellidoPaterno = @paterno, ApellidoMaterno = @materno, ";
                query += "Genero = @genero, Telefono = @telefono, Email = @email, Direccion = @direccion, Nacimiento = @nacimiento";
                query += " where ID = " + i + ";";
                OleDbCommand command = new OleDbCommand(query, conexion);
                command.Parameters.AddWithValue("@dni", contacto.DNI);
                command.Parameters.AddWithValue("@nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@paterno", contacto.ApellPaterno);
                command.Parameters.AddWithValue("@materno", contacto.ApellMaterno);
                command.Parameters.AddWithValue("@genero", contacto.Genero);
                command.Parameters.AddWithValue("@telefono", contacto.Telefono);
                command.Parameters.AddWithValue("@email", contacto.Email);
                command.Parameters.AddWithValue("@direccion", contacto.Direccion);
                command.Parameters.AddWithValue("@nacimiento", contacto.Nacimiento);

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro actualizar el contacto a la DB");
                close();
            }

            return conexion;
        }

        public OleDbDataReader RecuperarDatos(int f, string Colum, string para)
        {
            OleDbDataReader reader;
            try
            {
                conexionBD();
                string query = "SELECT * FROM TContactos";
                if(f == 1)
                {
                    query += " WHERE  " + Colum + " LIKE '" + para + "%';";
                }
                else
                {
                    query += ";";
                }
                OleDbCommand command = new OleDbCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;                
            }
            catch (SqlException e)
            {
                close();
                return null;
            }            
        }

        public OleDbDataReader Login(string User, string Pass)
        {            
            try
            {
                OleDbDataReader reader;
                conexionBD();
                string query = "SELECT * FROM TUsuarios";
                query += " WHERE  User = '" + User;
                query += "' AND Password = '" + Pass + "';";
                OleDbCommand command = new OleDbCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;

            }
            catch (SyntaxErrorException e)
            {
                MessageBox.Show("No se ingreso ningun parametro DB");
                close();
                return null;
            }          

        }
    }
}

