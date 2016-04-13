namespace ParseBody
{
    /// <summary>
    ///     Parse a html email
    /// </summary>
    internal class BodyMeesage
    {
        public string GetFrom(string messTop)
        {
            messTop = messTop.Remove(0, messTop.IndexOf("\r\nFrom:") + 5);
            messTop = messTop.Substring(0,messTop.IndexOf('>'));
            //messTop = messTop.Remove(0, messTop.Length - messTop.IndexOf('\r'));
            return messTop;
        }

        public string GetDate(string messTop)
        {
            messTop = messTop.Remove(0, messTop.IndexOf("\r\nDate:") + 7);
            messTop = messTop.Remove(messTop.IndexOf('\r'), messTop.Length - messTop.IndexOf('\r'));
            return messTop;
        }

        public string GetMessID(string messTop)
        {
            messTop = messTop.Remove(0, messTop.IndexOf("\r\nMessage-ID: ") + 13);
            messTop = messTop.Remove(messTop.IndexOf('\r'), messTop.Length - messTop.IndexOf('\r'));
            return messTop;
        }

        public string GetTo(string messTop)
        {
            messTop = messTop.Remove(0, messTop.IndexOf("\r\nTo:") + 6);
            messTop = messTop.Remove(messTop.IndexOf('\r'), messTop.Length - messTop.IndexOf('\r'));
            return messTop;
        }

        public string GetSubject(string messTop)
        {
            messTop = messTop.Remove(0, messTop.IndexOf("\r\nSubject:") + 10);
            messTop = messTop.Remove(messTop.IndexOf('\r'), messTop.Length - messTop.IndexOf('\r'));
            return messTop;
        }

        public string GetBody(string AllMessage)
        {
            if (AllMessage.Contains("<html"))
                AllMessage = AllMessage.Remove(0, AllMessage.IndexOf("<html"));
            return AllMessage;
        }
    }
}