namespace BusinessLogic
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class XMLNodes : DbContext
	{
		// Контекст настроен для использования строки подключения "XMLNodes" из файла конфигурации  
		// приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
		// "BusinessLogic.XMLNodes" в экземпляре LocalDb. 
		// 
		// Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "XMLNodes" 
		// в файле конфигурации приложения.
		public XMLNodes()
			: base("XMLNodes")
		{
		}
		public DbSet<DllNode> DllList { get; set; }

		// Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
		// о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}