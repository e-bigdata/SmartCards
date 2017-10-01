﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemCard;
using log4net;
using System.Security.Cryptography;
using System.IO;

namespace CardAPILib.InterfaceCL
{
    /// <summary>
    /// 
    /// </summary>
    public class SecureMessaging
    {
        private static ILog log = LogManager.GetLogger(typeof(SecureMessaging));
        private APDUResponse apduResp;

        private CardNative iCard;

        const ushort SC_OK = 0x9000;
        const byte SC_PENDING = 0x9F;

        public string LastOperationStatus { get; set; }

        private int Connect2Card()
        {
            try
            {
                log.Info("Connect2Card");

                string[] readers = iCard.ListReaders();

                string[] SpecReaders = (from reader in readers
                                        where reader.Contains("CL")
                                        select reader).ToArray();


                foreach (string readerInfo in SpecReaders)
                {
                    try
                    {
                        iCard.Disconnect(DISCONNECT.Unpower);

                    }
                    catch (Exception)
                    {
                        //
                    }

                    try
                    {
                        iCard.Connect(readerInfo, SHARE.Shared, PROTOCOL.T0orT1);

                        return 0;
                    }
                    catch (Exception)
                    {
                        //throw new ApduCommandException("Uneble to connect to Card");
                    }
                }

            }
            catch (Exception ex)
            {

                log.Info(ex.Message);

                throw new ApduCommandException("Uneble to connect to Card");
            }

            return 4;
        }

        /// <summary>
        /// 
        /// </summary>
        public SecureMessaging()
        {
            log.Info("SecureMessaging");

            iCard = new CardNative();
        }

        /// <summary>
        /// 
        /// </summary>
        public void EstablishSecureChannel()
        {
            byte[] get_challenge = new byte[8];

            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }


            {
                log.Info("00 A4 04 00 [07] A0 00 00 02 48 02 00 [00]");
                #region 00 A4 04 00 [07] A0 00 00 02 48 02 00 [00]
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0xA4, 0x04, 0x00, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = new byte[7] { 0xA0 ,0x00 ,0x00 ,0x02 ,0x48 ,0x02 ,0x00 };

                apduSize6_3.Update(apduParam6_3);

                apduResp = iCard.TransmitLe(apduSize6_3, 27);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }


            {
                log.Info("80CA0055 [00] ");
                #region 80CA0055 [00] 
                APDUCommand apduSize6_3 = new APDUCommand(0x80, 0xCA, 0x00, 0x55, null, 0);

                apduResp = iCard.TransmitLe(apduSize6_3, 7);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

            {
                log.Info("002231A4 [06] 80|01<01> 84|01<08> ");
                #region 002231A4 [06] 80|01<01> 84|01<08> 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x22, 0x31, 0xA4, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = new byte[6] { 0x80, 0x01, 0x01, 0x84, 0x01, 0x08 };

                apduSize6_3.Update(apduParam6_3);

                apduResp = iCard.Transmit(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }


            {
                log.Info("002231B8 [06] 80|01<01> 84|01<08>  ");
                #region 002231B8 [06] 80|01<01> 84|01<08> 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x22, 0x31, 0xB8, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = new byte[6] { 0x80, 0x01, 0x01, 0x84, 0x01, 0x08 };

                apduSize6_3.Update(apduParam6_3);

                apduResp = iCard.Transmit(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

            {
                log.Info("00840000 [08]  ");
                #region 00840000 [08] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x84, 0x00, 0x00, null, 8);

                apduResp = iCard.Transmit(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                Array.Copy(apduResp.Data, get_challenge, 8);

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

            byte [] mut_al = BAC_Calculate.CalcBAC_Res(get_challenge,null);

            {
                log.Info("00820000 [28] MUTUAL [00]  ");
                #region 00820000 [28]  MUTUAL [00] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x82, 0x00, 0x00, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = mut_al;

                apduSize6_3.Update(apduParam6_3);

                apduResp = iCard.TransmitLe(apduSize6_3, 40);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void InstallAppletV1()
        {
            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            {
                log.Info("80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 FD 42 42 00");

                #region 80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 FD 42 42 00

                APDUCommand apduSize5 = new APDUCommand(0x80, 0xE6, 0x0C, 0x00, null, 0);

                APDUParam apduParam5 = new APDUParam();

                apduParam5.Data = new byte[36] { 0x08, 0xD2, 0x76, 0x00, 0x00, 0x98, 0x45, 0x41, 0x43, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x48, 0x02, 0x01, 0x01, 0x08, 0x07, 0xC9, 0x05, 0x4C, 0x00, 0xFD, 0x42, 0x42, 0x00 };

                apduSize5.Update(apduParam5);

                apduResp = iCard.TransmitLe(apduSize5, 1, true);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File Not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }
                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void InstallAppletV3()
        {
            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            {
                log.Info("80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 00 02 0A 00");

                #region 80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 00 02 0A 00

                APDUCommand apduSize5 = new APDUCommand(0x80, 0xE6, 0x0C, 0x00, null, 0);

                APDUParam apduParam5 = new APDUParam();

                apduParam5.Data = new byte[36] { 0x08, 0xD2, 0x76, 0x00, 0x00, 0x98, 0x45, 0x41, 0x43, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x48, 0x02, 0x00, 0x01, 0x0C, 0x07, 0xC9, 0x05, 0x4C, 0x00, 0x00, 0x02, 0x0A, 0x00 };

                apduSize5.Update(apduParam5);

                apduResp = iCard.TransmitLe(apduSize5, 1, true);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File Not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }
                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void InstallAppletV5()
        {
            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            {
                log.Info("80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 FD 42 42 00");

                #region 80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 48 02 00 01 08 07 C9 05 4C 00 FD 42 42 00

                APDUCommand apduSize5 = new APDUCommand(0x80, 0xE6, 0x0C, 0x00, null, 0);

                APDUParam apduParam5 = new APDUParam();

                apduParam5.Data = new byte[36] { 0x08, 0xD2, 0x76, 0x00, 0x00, 0x98, 0x45, 0x41, 0x43, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x48, 0x02, 0x00, 0x01, 0x08, 0x07, 0xC9, 0x05, 0x4C, 0x00, 0xFD, 0x42, 0x42, 0x00 };

                apduSize5.Update(apduParam5);

                apduResp = iCard.TransmitLe(apduSize5, 1, true);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File Not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }
                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }


        /// <summary>
        /// 
        /// </summary>
        public void InstallAppletV2()
        {
            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            {
                log.Info("80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 47 10 01 01 08 07 C9 05 4C 00 FD 42 42 00");

                #region 80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 47 10 01 01 08 07 C9 05 4C 00 FD 42 42 00

                APDUCommand apduSize5 = new APDUCommand(0x80, 0xE6, 0x0C, 0x00, null, 1);

                APDUParam apduParam5 = new APDUParam();

                apduParam5.Data = new byte[36] { 0x08, 0xD2, 0x76, 0x00, 0x00, 0x98, 0x45, 0x41, 0x43, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x01, 0x08, 0x07, 0xC9, 0x05, 0x4C, 0x00, 0xFD, 0x42, 0x42, 0x00 };

                apduSize5.Update(apduParam5);

                apduResp = iCard.Transmit(apduSize5);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File Not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return ;
                    }

                    return ;
                }
                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void InstallAppletV4()
        {
            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            {
                log.Info("80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 47 10 01 01 08 07 C9 05 4C 00 FD 42 42 00");

                #region 80 E6 0C 00 [24] 08 D2 76 00 00 98 45 41 43 07 A0 00 00 02 47 10 01 07 A0 00 00 02 47 10 01 01 08 07 C9 05 4C 00 FD 42 42 00

                APDUCommand apduSize5 = new APDUCommand(0x80, 0xE6, 0x0C, 0x00, null, 1);

                APDUParam apduParam5 = new APDUParam();

                apduParam5.Data = new byte[36] { 0x08, 0xD2, 0x76, 0x00, 0x00, 0x98, 0x45, 0x41, 0x43, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x01, 0x07, 0xA0, 0x00, 0x00, 0x02, 0x47, 0x10, 0x02, 0x01, 0x08, 0x07, 0xC9, 0x05, 0x4C, 0x00, 0x00, 0x02, 0x0A, 0x00 };

                apduSize5.Update(apduParam5);

                apduResp = iCard.Transmit(apduSize5);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File Not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    return;
                }
                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }


        /// <summary>
        /// 
        /// </summary>
        public void EstablishSecureChannelV1()
        {
            byte[] get_challenge = new byte[8];

            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }


            {
                log.Info("00 A4 04 0C [07] A0 00 00 02 48 02 00 [00]");
                #region 00 A4 04 0C [07] A0 00 00 02 48 02 00 [00]
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0xA4, 0x04, 0x0C, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = new byte[7] { 0xA0, 0x00, 0x00, 0x02, 0x48, 0x02, 0x00 };

                apduSize6_3.Update(apduParam6_3);

                log.Info(apduSize6_3);

                apduResp = iCard.TransmitLe(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }


            {
                log.Info("00840000 [08]  ");
                #region 00840000 [08] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x84, 0x00, 0x00, null, 8);

                log.Info(apduSize6_3);

                apduResp = iCard.Transmit(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                Array.Copy(apduResp.Data, get_challenge, 8);

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

            byte[] mut_al = BAC_Calculate.CalcBAC_Res(get_challenge, null);

            {
                log.Info("00820000 [28] MUTUAL [00]  ");
                #region 00820000 [28]  MUTUAL [00] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x82, 0x00, 0x00, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = mut_al;

                apduSize6_3.Update(apduParam6_3);

                log.Info(apduSize6_3);

                apduResp = iCard.TransmitLe(apduSize6_3, 40);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }

        public void EstablishSecureChannelV2(byte[] mrzInfo)
        {
            byte[] get_challenge = new byte[8];

            if (Connect2Card() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }

            ExternalAuthentificate ext = new ExternalAuthentificate();

            if (ext.ExternalAuth() != 0)
            {
                log.Info("Connect to Card failed");
                return;
            }


            {
                log.Info("00 A4 04 0C [07] A0 00 00 02 48 02 00 [00]");
                #region 00 A4 04 0C [07] A0 00 00 02 48 02 00 [00]
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0xA4, 0x04, 0x0C, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = new byte[7] { 0xA0, 0x00, 0x00, 0x02, 0x48, 0x02, 0x00 };

                apduSize6_3.Update(apduParam6_3);

                log.Info(apduSize6_3);

                apduResp = iCard.TransmitLe(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }


            {
                log.Info("00840000 [08]  ");
                #region 00840000 [08] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x84, 0x00, 0x00, null, 8);

                log.Info(apduSize6_3);

                apduResp = iCard.Transmit(apduSize6_3);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                Array.Copy(apduResp.Data, get_challenge, 8);

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

            byte[] mut_al = BAC_Calculate.CalcBAC_Res(get_challenge, mrzInfo);

            {
                log.Info("00820000 [28] MUTUAL [00]  ");
                #region 00820000 [28]  MUTUAL [00] 
                APDUCommand apduSize6_3 = new APDUCommand(0x00, 0x82, 0x00, 0x00, null, 0);

                APDUParam apduParam6_3 = new APDUParam();

                apduParam6_3.Data = mut_al;

                apduSize6_3.Update(apduParam6_3);

                log.Info(apduSize6_3);

                apduResp = iCard.TransmitLe(apduSize6_3, 40);
                if (apduResp.Status != SC_OK && apduResp.SW1 != SC_PENDING)
                {
                    if (apduResp.ToString().Contains("6A82"))
                    {
                        string code = "File not Found";
                        LastOperationStatus = code;
                        log.Error(code);

                        return;
                    }

                    log.Info(apduResp.Status);
                    log.Info(apduResp.ToString());

                    return;
                }

                #endregion

                log.Info(apduResp.Status);
                log.Info(apduResp.ToString());
            }

        }
    }
}
