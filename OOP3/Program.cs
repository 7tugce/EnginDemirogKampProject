using OOP3;
using System.Collections.Generic;

ICreditManager needCreditManager = new NeedCreditManager();



ICreditManager vehicleCreditManager = new VehicleCreditManager();



ICreditManager housingCreditManager = new HousingCreditManager();
// interfaceler de referans tutar

ILoggerService fileLoggerService = new FileLoggerService();


ApplyManager applyManager = new ApplyManager();
applyManager.Appy(needCreditManager, new DatabaseLoggerService());// ekrandan seçildi sen de bunu verdin

List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager , vehicleCreditManager };

//applyManager.KrediOnBilgilendirmesiYap(credits);

// interfaceleri birbirinbin alterantifi olan ama kod içerikleri farklı olan durumnlar için kullanırız.

