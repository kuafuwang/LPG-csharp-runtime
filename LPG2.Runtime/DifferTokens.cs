using System;

namespace LPG2.Runtime
{

public class DifferTokens : Differ
{
    //
    // Class that encodes the meaningful content of a line.
    //
    public class Token : ILine
    {
        private int kind,
                    start_line,
                    start_column,
                    end_line,
                    end_column;
        private string name;

        private int hash_code;

        public Token(IPrsStream stream, int token)
        {
            this.kind = stream.getKind(token);
            this.name = stream.getName(token);
            this.start_line = stream.getLine(token);
            this.start_column = stream.getColumn(token);
            this.end_line = stream.getEndLine(token);
            this.end_column = stream.getEndColumn(token);
            hash_code = this.name.GetHashCode();
        }

        public  int size() { return name.Length; }

        public  int hashCode() { return hash_code; }

        public  bool equals(object anObject)
        {
            if (this == anObject)
                return true;

            if (anObject is Token)
            {
                Token another_token = (Token) anObject;
                return (this.kind == another_token.kind && this.name.Equals(another_token.name));
            }

            return false;
        }

        public  int getStartLine() { return start_line; }
        public  int getStartColumn() { return start_column; }
        public  int getEndLine() { return end_line; }
        public  int getEndColumn() { return end_column; }
        public  string toString() { return this.name; }
    }

    protected DifferTokens() {}
    
    public DifferTokens(IPrsStream newStream, IPrsStream oldStream) :base(newStream, oldStream)
    {
       
    }

    public override ILine[] getBuffer(IPrsStream stream)
    {
        Token[] buffer= new Token[stream.getStreamLength()];
        for (int i = 1; i < stream.getStreamLength(); i++)
            buffer[i] = new Token(stream, i);
        return buffer;
    }

    //
    //
    //
    void printLines(IPrsStream prs_stream, int first_token, int last_token)
    {
        int start_line = prs_stream.getLine(first_token),
            end_line = prs_stream.getLine(last_token);
        ILexStream lex_stream = prs_stream.getLexStream();

        char []char_buffer = null;
        byte []byte_buffer = null;
        if (lex_stream is LexStream)
             char_buffer = ((LexStream) lex_stream).getInputChars();            
        else if (lex_stream is Utf8LexStream)
             byte_buffer = ((Utf8LexStream) lex_stream).getInputBytes();            
        else throw new UnknownStreamType("Unknown stream type " +
                                         lex_stream.GetType().ToString());

        //
        // THIS IS TEMPORARY code just to show proof of concept.
        // TODO: Ultimately, we want to change the color of the affected
        // section in an IDE such as Eclipse...
        //
        int start = lex_stream.getLineOffset(start_line - 1) + 1,
            end = lex_stream.getLineOffset(start_line);
        if (start_line == end_line)
        {
            string num = "" + start_line;
            for (int i = 0; i < (6 - num.Length); i++)
                 Console.Out.Write(' ');
            string line = (char_buffer != null ? new string(char_buffer, start, end - start)
                                               : GetString(byte_buffer, start, end - start));
             Console.Out.WriteLine(start_line + " " + line);

             Console.Out.Write("       "); // 7 spaces: 6 for number and 1 blank.
            for (int i = 0; i < prs_stream.getColumn(first_token) - 1; i++)
                 Console.Out.Write(' ');
            int length = prs_stream.getEndColumn(last_token) - prs_stream.getColumn(first_token);
            if (length < 2)
                 Console.Out.WriteLine('^');
            else
            {
                 Console.Out.Write('<');
                for (int i = 1; i < length; i++)
                     Console.Out.Write('-');
                 Console.Out.WriteLine('>');
            }
        }
        else
        {
             Console.Out.Write("       "); // 7 spaces: 6 for number and 1 blank.
            for (int i = 0; i < prs_stream.getColumn(first_token) - 1; i++)
                 Console.Out.Write(' ');
            int last_column = lex_stream.getColumn(lex_stream.getPrevious(end));
             Console.Out.Write('<');
            for (int i = prs_stream.getColumn(first_token) + 1; i < last_column; i++)
                 Console.Out.Write('-');
             Console.Out.WriteLine();

            for (int line_no = start_line; line_no <= end_line; line_no++)
            {
                start = lex_stream.getLineOffset(line_no - 1) + 1;
                end = lex_stream.getLineOffset(line_no);
                string num = "" + line_no;
                for (int i = 0; i < (6 - num.Length); i++)
                     Console.Out.Write(' ');
                string line = (char_buffer != null ? new string(char_buffer, start, end - start)
                                                   : GetString(byte_buffer, start, end - start));
                 Console.Out.WriteLine(line_no + " " + line);

            }

             Console.Out.Write("       "); // 7 spaces: 6 for number and 1 blank.
            for (int i = 0; i < prs_stream.getEndColumn(last_token) - 1; i++)
                 Console.Out.Write('-');
             Console.Out.WriteLine('>');
        }
    }

        //
        //
        //
        public override void outputInsert(Change element)
    {
        insertCount += (element.getNewe() - element.getNews() + 1);
         Console.Out.WriteLine("Insert after " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(element.getOlde()) +
                           ":" +
                           oldStream.getEndColumn(element.getOlde()) +
                           " " +
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(element.getNews()) +
                           ":" +
                           newStream.getColumn(element.getNews()) +
                           ".." +
                           newStream.getLine(element.getNewe()) +
                           ":" +
                           newStream.getEndColumn(element.getNewe()) +
                           ":");
        printLines(newStream, element.getNews(), element.getNewe());
    }

    //
    //
    //
    public  override  void outputDelete(Change element)
    {
        deleteCount += (element.getOlde() - element.getOlds() + 1);
         Console.Out.WriteLine("Delete after " + 
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(element.getNewe()) +
                           ":" +
                           newStream.getEndColumn(element.getNewe()) +
                           " " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(element.getOlds()) +
                           ":" +
                           oldStream.getColumn(element.getOlds()) +
                           ".." +
                           oldStream.getLine(element.getOlde()) +
                           ":" +
                           oldStream.getEndColumn(element.getOlde()) +
                           ":");
        printLines(oldStream, element.getOlds(), element.getOlde());
    }

        //
        //
        //
        public override void outputReplace(Change element)
    {
        replaceDeleteCount += (element.getOlde() - element.getOlds() + 1);
        replaceInsertCount += (element.getNewe() - element.getNews() + 1);
         Console.Out.WriteLine("Replace " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(element.getOlds()) +
                           ":" +
                           oldStream.getColumn(element.getOlds()) +
                           ".." +
                           oldStream.getLine(element.getOlde()) +
                           ":" +
                           oldStream.getEndColumn(element.getOlde()) +
                           ":");
        printLines(oldStream, element.getOlds(), element.getOlde());

         Console.Out.WriteLine("With " +
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(element.getNews()) +
                           ":" +
                           newStream.getColumn(element.getNews()) +
                           ".." +
                           newStream.getLine(element.getNewe()) +
                           ":" +
                           newStream.getEndColumn(element.getNewe()) +
                           ":");
        printLines(newStream, element.getNews(), element.getNewe());
    }

        //
        //
        //
        public override void outputMove(Change element)
    {
         moveCount += (element.getNewe() - element.getNews() + 1);
          Console.Out.WriteLine("Move " +
                            oldStream.getFileName() +
                            "," +
                            oldStream.getLine(element.getOlds()) +
                            ":" +
                            oldStream.getColumn(element.getOlds()) +
                            ".." +
                            oldStream.getLine(element.getOlde()) +
                            ":" +
                            oldStream.getEndColumn(element.getOlde()) +
                            " to " +
                            newStream.getFileName() +
                            "," +
                            newStream.getLine(element.getNews()) +
                            ":" +
                            newStream.getColumn(element.getNews()) +
                            ".." +
                            newStream.getLine(element.getNewe()) +
                            ":" +
                            newStream.getEndColumn(element.getNewe()) +
                            ":");
        printLines(newStream, element.getNews(), element.getNewe());
    }

        //
        //
        //
        public override void outputMoveDelete(Change element)
    {
        int bound = element.getNewe() - element.getNews();
        moveCount += (bound + 1);
         Console.Out.WriteLine("Move " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(element.getOlds()) +
                           ":" +
                           oldStream.getColumn(element.getOlds()) +
                           ".." +
                           oldStream.getLine(element.getOlds() + bound) +
                           ":" +
                           oldStream.getEndColumn(element.getOlds() + bound) +
                           " to " +
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(element.getNews()) +
                           ":" +
                           newStream.getColumn(element.getNews()) +
                           ".." +
                           newStream.getLine(element.getNewe()) +
                           ":" +
                           newStream.getEndColumn(element.getNewe()) +
                           ":");
        printLines(newStream, element.getNews(), element.getNewe());

        int oldi = element.getOlds() + bound + 1;
        deleteCount += (element.getOlde() - oldi + 1);
         Console.Out.WriteLine("... And delete " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(oldi) +
                           ":" +
                           oldStream.getColumn(oldi) +
                           ".." +
                           oldStream.getLine(element.getOlde()) +
                           ":" +
                           oldStream.getEndColumn(element.getOlde()));
        printLines(oldStream, oldi, element.getOlde());
    }

        //
        //
        //
        public override void outputMoveInsert(Change element)
    {
        int bound = element.getOlde() - element.getOlds();
        moveCount += (element.getOlde() - element.getOlds() + 1);
         Console.Out.WriteLine("Move " +
                           oldStream.getFileName() +
                           "," +
                           oldStream.getLine(element.getOlds()) +
                           ":" +
                           oldStream.getColumn(element.getOlds()) +
                           ".." +
                           oldStream.getLine(element.getOlde()) +
                           ":" +
                           oldStream.getEndColumn(element.getOlde()) +
                           " to " +
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(element.getNews()) +
                           ":" +
                           newStream.getColumn(element.getNews()) +
                           ".." +
                           newStream.getLine(element.getNews() + bound) +
                           ":" +
                           newStream.getEndColumn(element.getNews() + bound) +
                           ":");
        printLines(newStream, element.getNews(), element.getNews() + bound);

        int newi = element.getNews() + bound + 1;
        insertCount += (element.getNewe() - newi + 1);
         Console.Out.WriteLine("... And insert " +
                           newStream.getFileName() +
                           "," +
                           newStream.getLine(newi) +
                           ":" +
                           newStream.getColumn(newi) +
                           ".." +
                           newStream.getLine(element.getNewe()) +
                           ":" +
                           newStream.getEndColumn(element.getNewe()) +
                           ":");
        printLines(newStream, newi, element.getNewe());
    }
}
}