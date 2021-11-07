using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class OutputToCSV : MonoBehaviour
{
    string filename = "";
    /* //For testing only
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WriteCSV();
            Debug.Log("AAAAAAAAAAA");
        }
    }
    */
    [System.Serializable]
    public class DataList
    {
        public ObjectData objData;
        public FluidData fluidData;
    }

    public DataList dataList = new DataList();

    public void WriteCSV()
    {
        Debug.Log("BBBBBBBBBBBBBB");
        string dateTime = DateTime.Now.Day.ToString() 
            + "-" + DateTime.Now.Month.ToString() 
            + "-" + DateTime.Now.Year.ToString() 
            + "_" + DateTime.Now.Hour.ToString() 
            + "-" + DateTime.Now.Minute.ToString() 
            + "-" + DateTime.Now.Second.ToString();
        filename = Application.dataPath + "CA3-Result_" + dateTime + ".csv";
        //check if obj data and fluid data are not empty
        TextWriter tw = new StreamWriter(filename, false);
        
        tw.WriteLine("CA3-Program results");
        tw.WriteLine("Variable, Data1, Data2, data 3"); //Change this line
        
        tw.Close();

        tw = new StreamWriter(filename, true);

        //tw.WriteLine();   //Data here

        tw.Close();
    }
}
