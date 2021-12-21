using BusinesObjects;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task = BusinessObjects.Task;

namespace DataObjects
{
    public class DbManager
    {
        private readonly string pathT = ConfigurationManager.AppSettings["TasksData"].ToString();
        private readonly string pathC = ConfigurationManager.AppSettings["CategoryData"].ToString();

        public List<Category> categories = new List<Category>();
        public List<Task> tasks= new List<Task>();

        private static DbManager Instance;

        public DbManager()
        {
            tasks = GetTasks();
            categories = GetCategories();
        }

        public static DbManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DbManager();
            }
            return Instance;
        }

        public void SaveTasks()
        {
            SerializeConfig<List<Task>>.Serialize(pathT, tasks);
        }
        public void SaveCategories()
        {
            SerializeConfig<List<Category>>.Serialize(pathC, categories);
        }

        public List<Task> GetTasks()
        {
            return SerializeConfig<List<Task>>.DeSerialize(pathT);
        }
        public List<Category> GetCategories()
        {
            return SerializeConfig<List<Category>>.DeSerialize(pathC);
        }
    }
}
