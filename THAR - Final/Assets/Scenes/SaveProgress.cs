using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveProgress
{
	public static int flag=0;
    // Start is called before the first frame update
    public static void Save()
    {
    	BinaryFormatter format=new BinaryFormatter();
    	string path = Application.persistentDataPath+"/progress.bin";
    	FileStream sf= new FileStream(path,FileMode.Create);
    	format.Serialize(sf,flag);
    	sf.Close();
    	Debug.Log(flag);
    }

    public static void Load()
    {
    	string path = Application.persistentDataPath+"/progress.bin";
    	if(File.Exists(path))
    	{
    		BinaryFormatter format=new BinaryFormatter();
    		FileStream sf= new FileStream(path,FileMode.Open);
    		int temp=(int)format.Deserialize(sf);
    		sf.Close();
    		flag=temp;

    	Debug.Log(flag);
    		//return temp;
    	}
    	//else
    	//	return 0;
    }
}
