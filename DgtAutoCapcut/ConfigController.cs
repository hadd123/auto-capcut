using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using LiteDB;

namespace DgtAutoCapcut;

public class ConfigController
{
	public static string dbconnection = "Filename=.\\config.db;connection=shared;upgrade=true";

	public static string dbProjectStateconnection = "Filename=.\\ProjectState.db;connection=shared;upgrade=true";

	public static string dblog = ".\\config-log.db";

	public static string db = ".\\config.db";

	private static string TableName = "Config";

	public static SemaphoreSlim semaphoredb = new SemaphoreSlim(1);

	public static void Insert(Config lstwafer)
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbconnection);
			ILiteCollection<Config> collection = liteDatabase.GetCollection<Config>(TableName);
			collection.DeleteAll();
			collection.Insert(lstwafer);
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

	public static void InsertProjectState(List<Capcut.AllDraftStore> lstwafer)
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbProjectStateconnection);
			ILiteCollection<Capcut.AllDraftStore> collection = liteDatabase.GetCollection<Capcut.AllDraftStore>(TableName);
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

	public static Config GetConfig()
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbconnection);
			IEnumerable<Config> source = liteDatabase.GetCollection<Config>(TableName).FindAll();
			if (source.Count() > 0)
			{
				return source.First();
			}
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
		}
		finally
		{
			semaphoredb.Release();
		}
		return new Config();
	}

	public static List<Capcut.AllDraftStore> GetProjectListConfig()
	{
		try
		{
			semaphoredb.Wait();
			using LiteDatabase liteDatabase = new LiteDatabase(dbProjectStateconnection);
			return liteDatabase.GetCollection<Capcut.AllDraftStore>(TableName).FindAll().ToList();
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
		}
		finally
		{
			semaphoredb.Release();
		}
		return new List<Capcut.AllDraftStore>();
	}
}
