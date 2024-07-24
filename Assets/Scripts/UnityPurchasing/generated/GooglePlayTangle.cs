// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("SPp5Wkh1fnFS/jD+j3V5eXl9eHuUtsDhFBR6eO+oxhXtZZnRzQmuadT6a09v+K7zeDjmKh8MQN5AjEQv2Ci2+nUN6txdPRkj6dx0WlRWi//LKxXkwbuED7qySF0f0qt/hIRSSDvQ5iB9wwU3ehK+sK9AOwIYIYfPjUNfa70aBDvl4Hx7Cme0zttLE8D6eXd4SPp5cnr6eXl41tvHtesNu5KDsBDDCxzh9S6ArTxAbcSA7f8oa7iGeLIhespVCSeynUFsiChp8cgyaq92rEc2jbP8AXCXLg2zFuH3saYu00njCWxisNEZPUccqG6StJBi7lGOXxS9ECUTTEWTr1Vwmjs0FF3r1m/ClF1kJ3SYC/7eFi7Bp+0Ss/3exY4tRPBln3p7eXh5");
        private static int[] order = new int[] { 0,8,5,7,10,7,13,8,11,12,11,13,12,13,14 };
        private static int key = 120;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
