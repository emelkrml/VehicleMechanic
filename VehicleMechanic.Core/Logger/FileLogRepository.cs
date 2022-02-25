using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Entity;

namespace VehicleMechanic.Core.Logger
{
    public class FileLogRepository<T> : ILogRepository<T>
        where T : class, ILog, new()
    {
        private readonly string filePath;

        public FileLogRepository(string _filePath)
        {
            filePath = _filePath;
            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "");
        }


        public void Add(T log)
        {
            List<T> json =
                JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath))
                ?? new List<T>();
            json.Add(log);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(json));
        }


        public void Delete(T log)
        {
            List<T> json =
                JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath))
                ?? new List<T>();
            json.Remove(log);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(json));
        }


        public List<T> GetList(Func<T, bool> filter = null)
        {
            List<T> json =
                JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath))
                ?? new List<T>();

            if (filter != null)
                json = json.Where(filter).ToList();
            return json;
        }
    }
}
