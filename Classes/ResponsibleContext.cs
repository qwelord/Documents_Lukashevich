using System.Collections.Generic;
using System.Data.OleDb;
using Documents_Lukashevich.Classes.Common;
using Documents_Lukashevich.Model;

namespace Documents_Lukashevich.Classes
{
    public class ResponsibleContext
    {
        public List<Responsible> GetAllResponsibles()
        {
            List<Responsible> responsibles = new List<Responsible>();
            OleDbConnection connection = DBConnect.Connection();
            OleDbDataReader data = DBConnect.Query("SELECT * FROM Ответственные", connection);
            while (data.Read())
            {
                responsibles.Add(new Responsible
                {
                    Код = data.GetInt32(0),
                    ФИО = data.GetString(1)
                });
            }
            DBConnect.CloseConnection(connection);
            return responsibles;
        }

        public void AddResponsible(string фио)
        {
            OleDbConnection connection = DBConnect.Connection();
            DBConnect.Query($"INSERT INTO Ответственные (ФИО) VALUES ('{фио}')", connection);
            DBConnect.CloseConnection(connection);
        }

        public void UpdateResponsible(int код, string фио)
        {
            OleDbConnection connection = DBConnect.Connection();
            DBConnect.Query($"UPDATE Ответственные SET ФИО = '{фио}' WHERE Код = {код}", connection);
            DBConnect.CloseConnection(connection);
        }

        public void DeleteResponsible(int код)
        {
            OleDbConnection connection = DBConnect.Connection();
            DBConnect.Query($"DELETE FROM Ответственные WHERE Код = {код}", connection);
            DBConnect.CloseConnection(connection);
        }
    }
}