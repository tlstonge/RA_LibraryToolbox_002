#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.OPCUAServer;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.CoreBase;
using FTOptix.Core;
#endregion

public class Runtime_StateMonAlias : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        string origNode = Owner.GetVariable("AliasPath").Value;
        var newNode = Project.Current.Get("CommDrivers" + origNode.Split("CommDrivers")[1] + "_StateMon");
        Owner.Get<Alias>("StateMon_Alias").Value = newNode.NodeId;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
