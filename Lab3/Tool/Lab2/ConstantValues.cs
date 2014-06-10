﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public static class ConstantValues
    {

        public const string CMD_STEP0_CREATE_PHONE0 = "HLEd -l * -d dict -i phones0.mlf config\\mkphone0.led words.mlf";
        public const string CMD_STEP0_CREATE_PHONE1 = "HLEd -l * -d dict -i phones1.mlf config\\mkphone1.led words.mlf";
        public const string CMD_STEP0_CREATE_MFC = "HCopy -T 1 -C config\\config.hcopy -S mfcc.scp";
        public const string CMD_STEP7_HMM0_CMD = "HCompV -C config\\config -f 0.01 -m -S train.scp -M hmm0 config\\proto";

        public const string CMD_STEP9_HMM1_TRAIN =
            "HERest -C config\\config -I phones0.mlf -S train.scp -H hmm0/macros -H hmm0/hmmdefs -M hmm1 monophones0";
        public const string CMD_STEP9_HMM2_TRAIN =
            "HERest -C config\\config -I phones0.mlf -S train.scp -H hmm0/macros -H hmm1/hmmdefs -M hmm2 monophones0";
        public const string CMD_STEP9_HMM3_TRAIN =
            "HERest -C config\\config -I phones0.mlf -S train.scp -H hmm0/macros -H hmm2/hmmdefs -M hmm3 monophones0";

        public const string CMD_STEP11_CONNECTSILSP = "HHEd -H hmm4/macros -H hmm4/hmmdefs -M hmm5 config\\sil.hed monophones1";

        public const string CMD_STEP12_TRAINTOHMM6 =
            "HERest -C config\\config -I phones0.mlf -S train.scp -H hmm5/macros -H hmm5/hmmdefs -M hmm6 monophones1";
        public const string CMD_STEP12_TRAINTOHMM7 =
           "HERest -C config\\config -I phones0.mlf -S train.scp -H hmm6/macros -H hmm6/hmmdefs -M hmm7 monophones1";

        public const string CMD_STEP13_TRAINTOHMM8 =
            "HERest -C config\\config -I aligned.mlf -S train.scp -H hmm7/macros -H hmm7/hmmdefs -M hmm8 monophones1";
        public const string CMD_STEP13_TRAINTOHMM9 =
           "HERest -C config\\config -I aligned.mlf -S train.scp -H hmm8/macros -H hmm8/hmmdefs -M hmm9 monophones1";

        public const string CMD_STEP14_CREATEWINTRI = "HLEd -n triphones1 -i wintri.mlf config\\mktri.led aligned.mlf";

        public const string CMD_STEP14_TRAINTOHMM10 =
            "HHEd -B -H hmm9/macros -H hmm9/hmmdefs -M hmm10 config\\mktri.hed monophones1";

        public const string CMD_STEP15_TRAINTOHMM11 =
            "HERest -B -C config\\config -I wintri.mlf -s stats -S train.scp -H hmm10/macros -H hmm10/hmmdefs -M hmm11 triphones1";

        public const string CMD_STEP15_TRAINTOHMM12 =
            "HERest -B -C config\\config -I wintri.mlf -s stats -S train.scp -H hmm11/macros -H hmm11/hmmdefs -M hmm12 triphones1";

        public const string CMD_STEP16_TRAINTOHMM13 =
            "HHEd -B -H hmm12/macros -H hmm12/hmmdefs -M hmm13 config\\tree.hed triphones1 > log";

        public const string CMD_STEP17_TRAINTOHMM14 =
            "HERest -B -C config\\config -I wintri.mlf -s stats -S train.scp -H hmm13/macros -H hmm13/hmmdefs -M hmm14 tiedlist";

        public const string CMD_STEP17_TRAINTOHMM15 =
            "HERest -B -C config\\config -I wintri.mlf -s stats -S train.scp -H hmm14/macros -H hmm14/hmmdefs -M hmm15 tiedlist";

        public const string CMD_TEST_STEP1_CREATEMFCC =
            "HCopy -T 1 -C config\\config.hcopy -S mfcc-test.scp";

        public const string CMD_TEST_STEP1_PARSEGRAM = "HParse  gram.txt   wdnet";
        public const string CMD_TEST_STEP1_RUN = 
            "HVite -H hmm15/macros -H hmm15/hmmdefs -S test.scp -i recout.mlf -w wdnet -p 0.0 -s 5.0 dict tiedlist";

        public const string CMD_TEST_STEP2_RESULT = "HResults -I test.mlf tiedlist recout.mlf";


        // lab 3 start here
        public const string CMD_STEP12_SLIDE33_PREPAREDDATA_HGEN_TRAIN =
            "HSGen.exe -l -n 10 wdnet.txt dict >> promptsADapt.txt";
        public const string CMD_STEP12_SLIDE33_PREPAREDDATA_HGEN_TEST =
           "HSGen.exe -l -n 10 wdnet.txt dict >> promptsTest.txt";
        public const string CMD_STEP12_SLIDE33_PREPAREDDATA_HCOPY_TRAIN =
          "HCopy.exe –C config –S codeAdapt.scp";
        public const string CMD_STEP12_SLIDE33_PREPAREDDATA_HCOPY_TEST =
           "HCopy.exe –C config –S codeTest.scp";


    }
}