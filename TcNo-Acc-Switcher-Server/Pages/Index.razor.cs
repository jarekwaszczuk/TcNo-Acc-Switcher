﻿// TcNo Account Switcher - A Super fast account switcher
// Copyright (C) 2019-2021 TechNobo (Wesley Pyburn)
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TcNo_Acc_Switcher_Globals;
using TcNo_Acc_Switcher_Server.Pages.General;
using TcNo_Acc_Switcher_Server.Pages.Steam;

namespace TcNo_Acc_Switcher_Server.Pages
{
    public partial class Index : ComponentBase
    {
        public async Task CheckSteam()
        {
            Globals.DebugWriteLine($@"[Func:Index.CheckSteam]");
            Steam.LoadFromFile();
            if (SteamSwitcherFuncs.SteamSettingsValid() && Directory.Exists(Steam.FolderPath) && File.Exists(Steam.Exe()))
            {
                NavManager.NavigateTo("/Steam/");
            }
            else
            {
                await GeneralInvocableFuncs.ShowModal("find:Steam:Steam.exe:SteamSettings");
            }
        }
        public async Task CheckOrigin()
        {
            Globals.DebugWriteLine($@"[Func:Index.CheckOrigin]");
            Origin.LoadFromFile();
            if (Directory.Exists(Origin.FolderPath) && File.Exists(Origin.Exe()))
            {
                NavManager.NavigateTo("/Origin/");
            }
            else
            {
                await GeneralInvocableFuncs.ShowModal("find:Origin:Origin.exe:OriginSettings");
            }
        }
        public async Task CheckUbisoft()
        {
            Globals.DebugWriteLine($@"[Func:Index.CheckUbisoft]");
            Ubisoft.LoadFromFile();
            if (Directory.Exists(Ubisoft.FolderPath) && File.Exists(Ubisoft.Exe()))
            {
                NavManager.NavigateTo("/Ubisoft/");
            }
            else
            {
                await GeneralInvocableFuncs.ShowModal("find:Ubisoft:upc.exe:UbisoftSettings");
            }
        }

        public async Task CheckBattleNet()
        {
            Globals.DebugWriteLine($@"[Func:Index.CheckBattleNet]");
            BattleNet.LoadFromFile();
            if (Directory.Exists(BattleNet.FolderPath) && File.Exists(BattleNet.BattleNetExe()))
            {
                NavManager.NavigateTo("/BattleNet/");
            }
            else
            {
                await GeneralInvocableFuncs.ShowModal("find:BattleNet:Battle.net.exe:BattleNetSettings");
            }
        }

        public void UpdateNow()
        {
            Process.Start(new ProcessStartInfo(@"updater\\TcNo-Acc-Switcher-Updater.exe") { UseShellExecute = true });
            Process.GetCurrentProcess().Kill();
        }
    }
}