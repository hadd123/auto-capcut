using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using LiteDB;

namespace DgtAutoCapcut;

public class CapcutController
{
	public static string dbconnection = D63390B3.D43F9903(210013u);

	public static string dblog = ".\\capcut-log.db";

	public static string db = ".\\capcut.db";

	public static SemaphoreSlim semaphoredb = new SemaphoreSlim(1);

	public static void InsertBulk(string TableName, List<Capcut.CommonAttr> lstwafer)
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbconnection);
			ILiteCollection<Capcut.CommonAttr> collection = liteDatabase.GetCollection<Capcut.CommonAttr>(TableName);
			collection.DeleteAll();
			collection.InsertBulk(lstwafer);
		}
		catch (Exception)
		{
			if (File.Exists(dblog))
			{
				File.Delete(dblog);
			}
			if (File.Exists(db))
			{
				File.Delete(db);
			}
		}
		finally
		{
			semaphoredb.Release();
		}
	}

	public static List<Capcut.CommonAttr> GetAll(string TableName)
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbconnection);
			IEnumerable<Capcut.CommonAttr> source = liteDatabase.GetCollection<Capcut.CommonAttr>(TableName).FindAll();
			if (source.Count() == 0)
			{
				return new List<Capcut.CommonAttr>();
			}
			return source.ToList();
		}
		catch (Exception ex)
		{
			Console.WriteLine("ERR GET:" + ex.Message);
			if (File.Exists(dblog))
			{
				File.Delete(dblog);
			}
			if (File.Exists(db))
			{
				File.Delete(db);
			}
			return new List<Capcut.CommonAttr>();
		}
		finally
		{
			semaphoredb.Release();
		}
	}
}
