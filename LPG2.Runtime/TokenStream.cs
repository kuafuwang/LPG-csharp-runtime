namespace LPG2.Runtime
{

    public interface TokenStream
    {
        int getToken();

        int getToken(int end_token);

        int getKind(int i);

        int getNext(int i);

        int getPrevious(int i);

        string getName(int i);

        int peek();

        void reset(int i);

        void reset();

        int badToken();

        int getLine(int i);

        int getColumn(int i);

        int getEndLine(int i);

        int getEndColumn(int i);

        bool afterEol(int i);

        string getFileName();

        int getStreamLength();

        int getFirstRealToken(int i);

        int getLastRealToken(int i);

        void reportError(int errorCode, int leftToken, int rightToken, string errorInfo);

        void reportError(int errorCode, int leftToken, int errorToken, int rightToken, string errorInfo);

        void reportError(int errorCode, int leftToken, int rightToken, string[] errorInfo);

        void reportError(int errorCode, int leftToken, int errorToken, int rightToken, string[] errorInfo);
    }
}