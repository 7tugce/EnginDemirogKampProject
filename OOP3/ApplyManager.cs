using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplyManager

    {// dependency injection
        public void Appy(ICreditManager creditManager , ILoggerService loggerService) // çoklu çalışmak isteseydin List<ILoggerService> yapacaktın
        {
            // başvuran bigileri eğerlendirme
            creditManager.Calculate();
            loggerService.Log();

        }
            public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)// birden fazla kredi seçmek için 
            {
            foreach (var credit in credits)
            {
                credit.Calculate();// listedeki herbir kredinin hesabını yap
            }
        }
    }
}
