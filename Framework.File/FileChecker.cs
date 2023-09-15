using System;

namespace Framework.File
{
    public static class FileChecker
    {
        public static bool IsValidFileName(this string FileName)
        {
            FileName =FileName.ToUpper();
            if (FileName.Contains(".ACTION") || FileName.Contains(".APK") ||
                FileName.Contains(".APP") || FileName.Contains(".BAT") ||
                FileName.Contains(".COMMAND") || FileName.Contains(".BIN") ||
                FileName.Contains(".CMD") || FileName.Contains(".COM") ||
                FileName.Contains(".CPL") || FileName.Contains(".CSH") ||
                FileName.Contains(".EX_") || FileName.Contains(".EXE") ||
                FileName.Contains(".GADGET") || FileName.Contains(".INF1") ||
                FileName.Contains(".INS") || FileName.Contains(".INX") ||
                FileName.Contains(".IPA") || FileName.Contains(".ISU") ||
                FileName.Contains(".JOB") || FileName.Contains(".JSE") ||
                FileName.Contains(".KSH") || FileName.Contains(".LNK") ||
                FileName.Contains(".MSC") || FileName.Contains(".MSI") ||
                FileName.Contains(".MSP") || FileName.Contains(".MST") ||
                FileName.Contains(".OSX") || FileName.Contains(".OUT") ||
                FileName.Contains(".PAF") || FileName.Contains(".PIF") ||
                FileName.Contains(".PRG") || FileName.Contains(".PS1") ||
                FileName.Contains(".REG") || FileName.Contains(".RGS") ||
                FileName.Contains(".RUN") || FileName.Contains(".SCR") ||
                FileName.Contains(".SCT") || FileName.Contains(".SHB") ||
                FileName.Contains(".SHS") || FileName.Contains(".U3P") ||
                FileName.Contains(".VB") || FileName.Contains(".VBE") ||
                FileName.Contains(".VBS") || FileName.Contains(".VBSCRIPT") ||
                FileName.Contains(".WORKFLOW") || FileName.Contains(".WS") ||
                FileName.Contains(".WSF") || FileName.Contains(".WSH") ||
                FileName.Contains(".0XE") || FileName.Contains(".73K") ||
                FileName.Contains(".89K") || FileName.Contains(".A6P") ||
                FileName.Contains(".AC") || FileName.Contains(".ACC") ||
                FileName.Contains(".ACR") || FileName.Contains(".ACTM") ||
                FileName.Contains(".AHK") || FileName.Contains(".AIR") ||
                FileName.Contains(".APP") || FileName.Contains(".ARSCRIPT") ||
                FileName.Contains(".AS") || FileName.Contains(".ASB") ||
                FileName.Contains(".AWK") || FileName.Contains(".AZW2") ||
                FileName.Contains(".BEAM") || FileName.Contains(".BTM") ||
                FileName.Contains(".CEL") || FileName.Contains(".CELX") ||
                FileName.Contains(".CHM") || FileName.Contains(".COF") ||
                FileName.Contains(".CRT") || FileName.Contains(".DEK") ||
                FileName.Contains(".DLD") || FileName.Contains(".DMC") ||
                FileName.Contains(".DOCM") || FileName.Contains(".DOTM") ||
                FileName.Contains(".DXL") || FileName.Contains(".EAR") ||
                FileName.Contains(".EBM") || FileName.Contains(".EBS") ||
                FileName.Contains(".EBS2") || FileName.Contains(".ECF") ||
                FileName.Contains(".EHAM") || FileName.Contains(".ELF") ||
                FileName.Contains(".ES") || FileName.Contains(".EX4") ||
                FileName.Contains(".EXOPC") || FileName.Contains(".EZS") ||
                FileName.Contains(".FAS") || FileName.Contains(".FKY") ||
                FileName.Contains(".FPI") || FileName.Contains(".FRS") ||
                FileName.Contains(".FXP") || FileName.Contains(".GS") ||
                FileName.Contains(".HAM") || FileName.Contains(".HMS") ||
                FileName.Contains(".HPF") || FileName.Contains(".HTA") ||
                FileName.Contains(".IIM") || FileName.Contains(".IPF") ||
                FileName.Contains(".ISP") || FileName.Contains(".JAR") ||
                FileName.Contains(".JS") || FileName.Contains(".JSX") ||
                FileName.Contains(".KIX") || FileName.Contains(".LO") ||
                FileName.Contains(".LS") || FileName.Contains(".MAM") ||
                FileName.Contains(".MCR") || FileName.Contains(".MEL") ||
                FileName.Contains(".MPX") || FileName.Contains(".MRC") ||
                FileName.Contains(".MS") || FileName.Contains(".MXE") ||
                FileName.Contains(".NEXE") || FileName.Contains(".OBS") ||
                FileName.Contains(".ORE") || FileName.Contains(".OTM") ||
                FileName.Contains(".PEX") || FileName.Contains(".PLX") ||
                FileName.Contains(".POTM") || FileName.Contains(".PPAM") ||
                FileName.Contains(".PPSM") || FileName.Contains(".PPTM") ||
                FileName.Contains(".PRC") || FileName.Contains(".PVD") ||
                FileName.Contains(".PWC") || FileName.Contains(".PYC") ||
                FileName.Contains(".PYO") || FileName.Contains(".QPX") ||
                FileName.Contains(".RBX") || FileName.Contains(".ROX") ||
                FileName.Contains(".RPJ") || FileName.Contains(".S2A") ||
                FileName.Contains(".SBS") || FileName.Contains(".SCA") ||
                FileName.Contains(".SCAR") || FileName.Contains(".SCB") ||
                FileName.Contains(".SCRIPT") || FileName.Contains(".SMM") ||
                FileName.Contains(".SPR") || FileName.Contains(".TCP") ||
                FileName.Contains(".THM") || FileName.Contains(".TLB") ||
                FileName.Contains(".TMS") || FileName.Contains(".UDF") ||
                FileName.Contains(".UPX") || FileName.Contains(".URL") ||
                FileName.Contains(".VLX") || FileName.Contains(".VPM") ||
                FileName.Contains(".WCM") || FileName.Contains(".WIDGET") ||
                FileName.Contains(".WIZ") || FileName.Contains(".WPK") ||
                FileName.Contains(".WPM") || FileName.Contains(".XAP") ||
                FileName.Contains(".XBAP") || FileName.Contains(".XLAM") ||
                FileName.Contains(".XLM") || FileName.Contains(".XLSM") ||
                FileName.Contains(".XLTM") || FileName.Contains(".XQT") ||
                FileName.Contains(".XYS") || FileName.Contains(".ZL9")||
                FileName.Contains(".ASAX") || FileName.Contains(".ASCX") ||
                FileName.Contains(".ASHX") || FileName.Contains(".ASMX") ||
                FileName.Contains(".ASPX") || FileName.Contains(".AXD") ||
                FileName.Contains(".BROWSER") || FileName.Contains(".CD") ||
                FileName.Contains(".COMPILE") || FileName.Contains(".CONFIG") ||
                FileName.Contains(".CS") || FileName.Contains(".JSL") ||
                FileName.Contains(".VB") || FileName.Contains(".CSPROJ") ||
                FileName.Contains(".VBPROJ") || FileName.Contains(".VJPROJ") ||
                FileName.Contains(".DISCO") || FileName.Contains(".VSDISCO") ||
                FileName.Contains(".DSDGM") || FileName.Contains(".DSPROTOTYPE") ||
                FileName.Contains(".DLL") || FileName.Contains(".LICX") ||
                FileName.Contains(".WEBINFO") || FileName.Contains(".MASTER") ||
                FileName.Contains(".MSGX") || FileName.Contains(".SVC") ||
                FileName.Contains(".REM") || FileName.Contains(".RESOURCES")||
                FileName.Contains(".MDB") || FileName.Contains(".LDB") ||
                FileName.Contains(".SSDGM") || FileName.Contains(".LSAD") ||
                FileName.Contains(".SSMAP") || FileName.Contains(".LSAPROTOTYPE") ||
                FileName.Contains(".SDM") || FileName.Contains(".SDMDOCUMENT") ||
                FileName.Contains(".MDF") || FileName.Contains(".LDF") ||
                FileName.Contains(".AD") || FileName.Contains(".DD") ||
                FileName.Contains(".LDD") || FileName.Contains(".SD") ||
                FileName.Contains(".ADPROTOTYPE") || FileName.Contains(".LDDPROTOTYPE") ||
                FileName.Contains(".EXCLUDE") || FileName.Contains(".REFRESH") ||
                FileName.Contains(".COMPILED") )
            {
                return false;
            }
            return true;
        }
        public static bool IsValidImageFileName(this string FileName)
        {
            FileName = FileName.ToUpper();
            if(FileName.Contains(".JPG") || FileName.Contains(".TIFF") || FileName.Contains(".SVG") || FileName.Contains(".GIF") || FileName.Contains(".PNG") || FileName.Contains(".JPEG"))
            {
                return true;
            }
            return false;
        }
        public static bool IsValidPdfFile(this string FileName)
        {
            FileName = FileName.ToUpper();
            if (FileName.Contains(".PDF"))
            {
                return true;
            }
            return false;
        }
        public static string ToUniqueFileName(this string FileName)
        {
            return   DateTime.Now.ToString().Replace("-","").Replace(":","").Replace(" ","").Replace(".","").Replace("/","") + "_" + FileName.Replace(" ", "_") ;
        }
        public static bool IsValidFileNameLength(this string FileName)
        {
            if (FileName.Length > 133)
            {
                return true;
            }
            return false;
        }
    }
}
