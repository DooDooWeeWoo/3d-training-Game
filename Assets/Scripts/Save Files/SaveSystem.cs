using System.IO; //System.IO allows for the creation and tinkering of files
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary; //This allows for the creation of binary formatted files which encrypt the save files so that they cant be edited easily

public static class SaveSystem { //create a static class

    public static void SavePlayer (Stats stats) //create a static method for saving the player
    {
        BinaryFormatter formatter = new BinaryFormatter(); //create a new binary formatter
        string path = Application.persistentDataPath + "/player.dfp"; //create a persistent file path where the save files will be saved
        FileStream stream = new FileStream(path, FileMode.Create); //stream that data to that filepath and create//overwrite a file

        PlayerData data = new PlayerData(stats); //grab the stats which was stored in the PlayerData Script

        formatter.Serialize(stream, data); //encrypt the file stream
        stream.Close(); //close the file stream
    }

    public static PlayerData LoadPlayer () //create a static method for loading the player
    {
        string path = Application.persistentDataPath + "/player.dfp"; //find the path which has been created
        if (File.Exists(path)) //check if the path exists
        {
            BinaryFormatter formatter = new BinaryFormatter(); //Create a new binary formatter
            FileStream stream = new FileStream(path, FileMode.Open); //open up the file stream from the path

            PlayerData data = formatter.Deserialize(stream) as PlayerData; //un-encrypt the data from the stream
            stream.Close(); //close the stream

            return data; //return the data to PlayerData
        }
        else //if error
        {
            Debug.LogError("Save file not found in " + path); //display error
            return null; //return nothign
        }
    }

}
