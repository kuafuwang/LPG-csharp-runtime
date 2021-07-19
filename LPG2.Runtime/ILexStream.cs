namespace LPG2.Runtime
{

    public interface ILexStream : TokenStream
    {
        IPrsStream getIPrsStream();

        /**
     * @deprecated replaced by {@link #getIPrsStream()}
     */
        IPrsStream getPrsStream();

        void setPrsStream(IPrsStream stream);

        int getLineCount();

        string[] orderedExportedSymbols();

        int getLineOffset(int i);

        int getLineNumberOfCharAt(int i);

        int getColumnOfCharAt(int i);

        char getCharValue(int i);

        int getIntValue(int i);

        void makeToken(int startLoc, int endLoc, int kind);

        void setMessageHandler(IMessageHandler errMsg);
        IMessageHandler getMessageHandler();

        /**
     * See IMessaageHandler for a description of the int[] return value.
     */
        int[] getLocation(int left_loc, int right_loc);

        void reportLexicalError(int left, int right);

        void reportLexicalError(int errorCode, int left_loc, int right_loc, int error_left_loc, int error_right_loc,
            string[] errorInfo);

        string ToString(int startOffset, int endOffset);
    }
}
