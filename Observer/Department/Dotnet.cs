using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Department
{
    public interface IDotnet 
    {
        void CalculateSalary();
    }
    public class Dotnet : IDotnet, IResignationObserver
    {
        public Dotnet(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalculateSalary()
        {

        }

        public void Notify(string employeeId)
        {
            //если сотрудник уходит в отставку уведомление
            //будет приходить сюда
            UpdXmlFile xmlFile = new UpdXmlFile();
            xmlFile.UpdateNotificationDetail("Dotnet", employeeId);
        }
    }
}
