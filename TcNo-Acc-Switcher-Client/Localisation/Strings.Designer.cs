﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TcNo_Acc_Switcher_Client.Localisation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TcNo_Acc_Switcher_Client.Localisation.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear backups.
        /// </summary>
        internal static string AreYouSure {
            get {
                return ResourceManager.GetString("AreYouSure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to clear backups of forgotten accounts?.
        /// </summary>
        internal static string ClearBackups {
            get {
                return ResourceManager.GetString("ClearBackups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deleting files.
        /// </summary>
        internal static string ErrDeleteFilesHeader {
            get {
                return ResourceManager.GetString("ErrDeleteFilesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete folder because it&apos;s not empty:.
        /// </summary>
        internal static string ErrDeleteFolderNonempty {
            get {
                return ResourceManager.GetString("ErrDeleteFolderNonempty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty profile image detected (0 bytes). Can&apos;t delete to redownload.
        ///
        ///Error information:.
        /// </summary>
        internal static string ErrEmptyImage {
            get {
                return ResourceManager.GetString("ErrEmptyImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Empty Image Error.
        /// </summary>
        internal static string ErrEmptyImageHeader {
            get {
                return ResourceManager.GetString("ErrEmptyImageHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not connect and download Steam profile&apos;s image from Steam servers.
        ///Check your internet connection.
        ///
        ///Details:.
        /// </summary>
        internal static string ErrImageDownloadFail {
            get {
                return ResourceManager.GetString("ErrImageDownloadFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error information:.
        /// </summary>
        internal static string ErrInformation {
            get {
                return ResourceManager.GetString("ErrInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error loading the &apos;loginusers.vdf&apos; file:.
        /// </summary>
        internal static string ErrLoadingLoginusers {
            get {
                return ResourceManager.GetString("ErrLoadingLoginusers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t start account switcher when loginusers.vdf does not exist. Verify Steam&apos;s installation and try again.
        ///If you just deleted loginusers.vdf, try starting and logging with Steam at least once..
        /// </summary>
        internal static string ErrLoginusersNonExist {
            get {
                return ResourceManager.GetString("ErrLoginusersNonExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - loginusers.vdf doesn&apos;t exist.
        /// </summary>
        internal static string ErrLoginusersNonExistHeader {
            get {
                return ResourceManager.GetString("ErrLoginusersNonExistHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Image download error.
        /// </summary>
        internal static string ErrProfileImageDlFail {
            get {
                return ResourceManager.GetString("ErrProfileImageDlFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not recursively delete directory! Error:.
        /// </summary>
        internal static string ErrRecursivelyDelete {
            get {
                return ResourceManager.GetString("ErrRecursivelyDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam location not chosen. Resetting to old value:.
        /// </summary>
        internal static string ErrSteamLocation {
            get {
                return ResourceManager.GetString("ErrSteamLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SteamSettings.json failed to load properly.
        ///Old settings are saved in settings.old.json, and a new config has been loaded..
        /// </summary>
        internal static string ErrSteamSettingsLoadFail {
            get {
                return ResourceManager.GetString("ErrSteamSettingsLoadFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Load Error.
        /// </summary>
        internal static string ErrSteamSettingsLoadFailHeader {
            get {
                return ResourceManager.GetString("ErrSteamSettingsLoadFailHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error switching account!.
        /// </summary>
        internal static string ErrSwitchingAcc {
            get {
                return ResourceManager.GetString("ErrSwitchingAcc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A username was not found in loginusers.vdf, but we looked for one with the provided SteamID. .
        /// </summary>
        internal static string ErrSwitchingAcc_MissingUsername {
            get {
                return ResourceManager.GetString("ErrSwitchingAcc_MissingUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UNHANDLED CRASH.
        /// </summary>
        internal static string ErrUnhandledCrash {
            get {
                return ResourceManager.GetString("ErrUnhandledCrash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Update check error.
        /// </summary>
        internal static string ErrUpdateCheckHeader {
            get {
                return ResourceManager.GetString("ErrUpdateCheckHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program will now close. Once opened, new images will download..
        /// </summary>
        internal static string InfoReopenImageDl {
            get {
                return ResourceManager.GetString("InfoReopenImageDl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shortcut to: {} was deleted!.
        /// </summary>
        internal static string InfoShortcutDeleted {
            get {
                return ResourceManager.GetString("InfoShortcutDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher will start in the Windows Tray on user login/startup (The small icons on the bottom right of your Windows Start bar.).
        /// </summary>
        internal static string InfoTrayWindowsStart {
            get {
                return ResourceManager.GetString("InfoTrayWindowsStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher will no longer start with user login/startup..
        /// </summary>
        internal static string InfoTrayWindowsStartOff {
            get {
                return ResourceManager.GetString("InfoTrayWindowsStartOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are required to pick a Steam directory for this program to work. Please check you have it installed and run this program again..
        /// </summary>
        internal static string RequiredPickSteamDir {
            get {
                return ResourceManager.GetString("RequiredPickSteamDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected.
        /// </summary>
        internal static string StatusAccountSelected {
            get {
                return ResourceManager.GetString("StatusAccountSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Checking VAC status for each account..
        /// </summary>
        internal static string StatusCheckingVac {
            get {
                return ResourceManager.GetString("StatusCheckingVac", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Checking VAC status:.
        /// </summary>
        internal static string StatusCheckingVacActive {
            get {
                return ResourceManager.GetString("StatusCheckingVacActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Closing Steam.
        /// </summary>
        internal static string StatusClosingSteam {
            get {
                return ResourceManager.GetString("StatusClosingSteam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Collecting Steam Accounts..
        /// </summary>
        internal static string StatusCollectingAccounts {
            get {
                return ResourceManager.GetString("StatusCollectingAccounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Downloading profile image:.
        /// </summary>
        internal static string StatusDownloadingProfile {
            get {
                return ResourceManager.GetString("StatusDownloadingProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Editing loginusers.vdf.
        /// </summary>
        internal static string StatusEditingLoginusers {
            get {
                return ResourceManager.GetString("StatusEditingLoginusers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Editing Steam&apos;s Registry keys.
        /// </summary>
        internal static string StatusEditingRegistry {
            get {
                return ResourceManager.GetString("StatusEditingRegistry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from loginusers.vdf.
        /// </summary>
        internal static string StatusFromLoginusers {
            get {
                return ResourceManager.GetString("StatusFromLoginusers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Starting image download..
        /// </summary>
        internal static string StatusImageDownloadStart {
            get {
                return ResourceManager.GetString("StatusImageDownloadStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2. Press Login.
        /// </summary>
        internal static string StatusPressLogin {
            get {
                return ResourceManager.GetString("StatusPressLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Ready.
        /// </summary>
        internal static string StatusReady {
            get {
                return ResourceManager.GetString("StatusReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Removing.
        /// </summary>
        internal static string StatusRemoving {
            get {
                return ResourceManager.GetString("StatusRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Started Steam.
        /// </summary>
        internal static string StatusStartedSteam {
            get {
                return ResourceManager.GetString("StatusStartedSteam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher is already running.
        /// </summary>
        internal static string SwitcherAlreadyRunning {
            get {
                return ResourceManager.GetString("SwitcherAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Duplicate start.
        /// </summary>
        internal static string SwitcherAlreadyRunningHeading {
            get {
                return ResourceManager.GetString("SwitcherAlreadyRunningHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version.
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string XBtnCancel {
            get {
                return ResourceManager.GetString("XBtnCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close.
        /// </summary>
        internal static string XBtnClose {
            get {
                return ResourceManager.GetString("XBtnClose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locate Steam.exe.
        /// </summary>
        internal static string XBtnLocateSteamExe {
            get {
                return ResourceManager.GetString("XBtnLocateSteamExe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore selected.
        /// </summary>
        internal static string XBtnRestoreSelected {
            get {
                return ResourceManager.GetString("XBtnRestoreSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Steam Folder.
        /// </summary>
        internal static string XBtnSelectSteamFolder {
            get {
                return ResourceManager.GetString("XBtnSelectSteamFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run Steam as Admin.
        /// </summary>
        internal static string XChkRunSteamAsAdmin {
            get {
                return ResourceManager.GetString("XChkRunSteamAsAdmin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show account name [not friend name].
        /// </summary>
        internal static string XChkShowAccName {
            get {
                return ResourceManager.GetString("XChkShowAccName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show SteamID.
        /// </summary>
        internal static string XChkShowSteamId {
            get {
                return ResourceManager.GetString("XChkShowSteamId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show VAC Status.
        /// </summary>
        internal static string XChkShowVACStatus {
            get {
                return ResourceManager.GetString("XChkShowVACStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start with Windows.
        /// </summary>
        internal static string XChkStartWindows {
            get {
                return ResourceManager.GetString("XChkStartWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kill Steam processes.
        /// </summary>
        internal static string XClearLoginsBtnKillSteam {
            get {
                return ResourceManager.GetString("XClearLoginsBtnKillSteam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clicking a button will delete the related file(s) from your Steam installation.
        ///Deleting loginusers.vdf will result in this account switcher showing no accounts.
        ///You will need to login to them using Steam to get them back..
        /// </summary>
        internal static string XClearLoginsDescription {
            get {
                return ResourceManager.GetString("XClearLoginsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More information (Wiki).
        /// </summary>
        internal static string XClearLoginsMoreInfo {
            get {
                return ResourceManager.GetString("XClearLoginsMoreInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Steam Cleaning.
        /// </summary>
        internal static string XClearLoginsTitle {
            get {
                return ResourceManager.GetString("XClearLoginsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I understand what these buttons do..
        /// </summary>
        internal static string XClearLoginsUnderstand {
            get {
                return ResourceManager.GetString("XClearLoginsUnderstand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are about to forget an account!.
        /// </summary>
        internal static string XForgetP1Title {
            get {
                return ResourceManager.GetString("XForgetP1Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - Steam will no longer have the account listed in Big Picture Mode and will not Remember Password.
        ///- TcNo Account Switcher will also no longer show the account, until it&apos;s signed into again via Steam.
        ///
        ///You account will remain untouched. It is just forgotten on this computer..
        /// </summary>
        internal static string XForgetP2 {
            get {
                return ResourceManager.GetString("XForgetP2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What does this mean?.
        /// </summary>
        internal static string XForgetP2Title {
            get {
                return ResourceManager.GetString("XForgetP2Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t panic, you can bring back forgotten accounts via backups in the Settings window.
        ///You can also remove previous backups from there when you are sure everything is working as expected.
        ///
        ///Right-click &gt;&gt; Forget and using the Delete key will both work..
        /// </summary>
        internal static string XForgetP3 {
            get {
                return ResourceManager.GetString("XForgetP3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What if something goes wrong?.
        /// </summary>
        internal static string XForgetP3Title {
            get {
                return ResourceManager.GetString("XForgetP3Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forget Account?.
        /// </summary>
        internal static string XForgetTitle {
            get {
                return ResourceManager.GetString("XForgetTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add New.
        /// </summary>
        internal static string XMainAddNew {
            get {
                return ResourceManager.GetString("XMainAddNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login.
        /// </summary>
        internal static string XMainLogin {
            get {
                return ResourceManager.GetString("XMainLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1. Select an account.
        /// </summary>
        internal static string XMainSelect {
            get {
                return ResourceManager.GetString("XMainSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status: Starting.
        /// </summary>
        internal static string XMainStartingStatus {
            get {
                return ResourceManager.GetString("XMainStartingStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I have read and understand.
        /// </summary>
        internal static string XReadAndUnderstand {
            get {
                return ResourceManager.GetString("XReadAndUnderstand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of available backups:.
        /// </summary>
        internal static string XRestoreList {
            get {
                return ResourceManager.GetString("XRestoreList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max number of accounts to remember:.
        /// </summary>
        internal static string XSettingsAccountsTotal {
            get {
                return ResourceManager.GetString("XSettingsAccountsTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Advanced cleaning....
        /// </summary>
        internal static string XSettingsAdvCleaning {
            get {
                return ResourceManager.GetString("XSettingsAdvCleaning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Desktop shortcut.
        /// </summary>
        internal static string XSettingsChkDesktopShortcuts {
            get {
                return ResourceManager.GetString("XSettingsChkDesktopShortcuts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start menu shortcut.
        /// </summary>
        internal static string XSettingsChkStartMenu {
            get {
                return ResourceManager.GetString("XSettingsChkStartMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear forgotten backups.
        /// </summary>
        internal static string XSettingsClearForgotten {
            get {
                return ResourceManager.GetString("XSettingsClearForgotten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile images expire after:.
        /// </summary>
        internal static string XSettingsImagesExpire {
            get {
                return ResourceManager.GetString("XSettingsImagesExpire", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Days.
        /// </summary>
        internal static string XSettingsImagesExpire2 {
            get {
                return ResourceManager.GetString("XSettingsImagesExpire2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Steam Folder.
        /// </summary>
        internal static string XSettingsOpenSteam {
            get {
                return ResourceManager.GetString("XSettingsOpenSteam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset images.
        /// </summary>
        internal static string XSettingsResetImages {
            get {
                return ResourceManager.GetString("XSettingsResetImages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset settings.
        /// </summary>
        internal static string XSettingsResetSettings {
            get {
                return ResourceManager.GetString("XSettingsResetSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore forgotten account.
        /// </summary>
        internal static string XSettingsRestore {
            get {
                return ResourceManager.GetString("XSettingsRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        internal static string XSettingsSepGeneral {
            get {
                return ResourceManager.GetString("XSettingsSepGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shortcuts.
        /// </summary>
        internal static string XSettingsSepShortcuts {
            get {
                return ResourceManager.GetString("XSettingsSepShortcuts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam Tools.
        /// </summary>
        internal static string XSettingsSepSteamTools {
            get {
                return ResourceManager.GetString("XSettingsSepSteamTools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tray settings.
        /// </summary>
        internal static string XSettingsSepTray {
            get {
                return ResourceManager.GetString("XSettingsSepTray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pick Steam folder.
        /// </summary>
        internal static string XSettingsSteamFolder {
            get {
                return ResourceManager.GetString("XSettingsSteamFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TcNo Account Switcher - Steam Settings.
        /// </summary>
        internal static string XSettingsTitle {
            get {
                return ResourceManager.GetString("XSettingsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check account VAC Status.
        /// </summary>
        internal static string XSettingsVacStatus {
            get {
                return ResourceManager.GetString("XSettingsVacStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam.exe found!.
        /// </summary>
        internal static string XSteamInputFound {
            get {
                return ResourceManager.GetString("XSteamInputFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam.exe not found.
        /// </summary>
        internal static string XSteamInputNotFound {
            get {
                return ResourceManager.GetString("XSteamInputNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam was not found in.
        /// </summary>
        internal static string XSteamInputText1 {
            get {
                return ResourceManager.GetString("XSteamInputText1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program Files.
        /// </summary>
        internal static string XSteamInputText2 {
            get {
                return ResourceManager.GetString("XSteamInputText2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to or.
        /// </summary>
        internal static string XSteamInputText3 {
            get {
                return ResourceManager.GetString("XSteamInputText3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program Files (x86)..
        /// </summary>
        internal static string XSteamInputText4 {
            get {
                return ResourceManager.GetString("XSteamInputText4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter Steam&apos;s directory, as such: C:\Program Files\Steam.
        /// </summary>
        internal static string XSteamInputText5 {
            get {
                return ResourceManager.GetString("XSteamInputText5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locate Steam.
        /// </summary>
        internal static string XSteamInputTitle {
            get {
                return ResourceManager.GetString("XSteamInputTitle", resourceCulture);
            }
        }
    }
}
