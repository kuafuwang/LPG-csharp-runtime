using System;
using System.Text;

namespace LPG2.Runtime
{

    public class DifferLines : Differ
    {
        //
        // Class that encodes the meaningful content of a line.
        //
        public class Line : ILine
        {
            private int[] kind;
            private string[] name;

            private int hash_code,
                start_line,
                start_column,
                end_line,
                end_column,
                buffer_length;

            public Line(IPrsStream stream, int start_token, int gate_token)
            {
                int size = (gate_token > start_token ? gate_token - start_token : 0),
                    end_token = gate_token - 1;

                this.start_line = stream.getLine(start_token);
                this.start_column = stream.getColumn(start_token);
                if (size > 0)
                {
                    this.end_line = stream.getEndLine(end_token);
                    this.end_column = stream.getEndColumn(end_token);
                }
                else
                {
                    this.end_line = stream.getLine(start_token);
                    this.end_column = stream.getColumn(start_token);
                }

                this.kind = new int[size];
                this.name = new string[size];

                hash_code = size;
                for (int i = 0; i < size; i++)
                {
                    this.kind[i] = stream.getKind(start_token + i);
                    this.name[i] = stream.getName(start_token + i);
                    buffer_length += (this.name[i].Length + 1);
                    hash_code += this.kind[i];
                }

                hash_code += buffer_length;
            }

            public int size()
            {
                return kind.Length;
            }

            public override int GetHashCode()
            {
                return hash_code;
            }

            public override bool Equals(object anObject)
            {
                if (this == anObject)
                    return true;

                if (anObject is Line)
                {
                    Line another_line = (Line) anObject;

                    if (this.kind.Length == another_line.kind.Length)
                    {
                        int i;
                        for (i = 0; i < kind.Length; i++)
                        {
                            if (!(this.kind[i] == another_line.kind[i] && this.name[i].Equals(another_line.name[i])))
                                break;
                        }

                        return i == this.kind.Length;
                    }
                }

                return false;
            }

            public int getStartLine()
            {
                return start_line;
            }

            public int getStartColumn()
            {
                return start_column;
            }

            public int getEndLine()
            {
                return end_line;
            }

            public int getEndColumn()
            {
                return end_column;
            }

            public override string ToString()
            {
                StringBuilder buffer = new StringBuilder(buffer_length);
                if (name.Length > 0)
                {
                    buffer.Append(name[0]);
                    for (int i = 1; i < name.Length; i++)
                    {
                        buffer.Append(" ");
                        buffer.Append(name[i]);
                    }
                }

                return buffer.ToString();
            }
        }

        public DifferLines(IPrsStream newStream, IPrsStream oldStream) : base(newStream, oldStream)
        {

        }

        protected DifferLines()
        {
        }

        public override ILine[] getBuffer(IPrsStream prsStream)
        {
            ILexStream lex_stream = prsStream.getLexStream();
            Line[] buffer = new Line[lex_stream.getLineCount() + 1];

            int token = 1;
            buffer[0] = new Line(prsStream, 0, 0);
            for (int line_no = 1; line_no < buffer.Length; line_no++)
            {
                int first_token = token;
                while (token < prsStream.getSize() && prsStream.getLine(token) == line_no)
                    token++;
                buffer[line_no] = new Line(prsStream, first_token, token);
            }

            return buffer;
        }

        //
        //
        //
        void printLines(IPrsStream prs_stream, int first_line, int last_line)
        {
            if (prs_stream.getLexStream() is LexStream)
            {
                LexStream lex_stream = (LexStream) prs_stream.getLexStream();
                char[] buffer = lex_stream.getInputChars();

                for (int line_no = first_line; line_no <= last_line; line_no++)
                {
                    int start = lex_stream.getLineOffset(line_no - 1) + 1,
                        end = lex_stream.getLineOffset(line_no);
                    string num = line_no + " ";
                    for (int i = 0; i < (7 - num.Length); i++)
                        Console.Out.Write(' ');
                    string line = num + new string(buffer, start, end - start);
                    Console.Out.WriteLine(line);
                }
            }
            else if (prs_stream.getLexStream() is Utf8LexStream)
            {
                Utf8LexStream lex_stream = (Utf8LexStream) prs_stream.getLexStream();
                byte[] buffer = lex_stream.getInputBytes();

                for (int line_no = first_line; line_no <= last_line; line_no++)
                {
                    int start = lex_stream.getLineOffset(line_no - 1) + 1,
                        end = lex_stream.getLineOffset(line_no);
                    string num = line_no + " ";
                    for (int i = 0; i < (7 - num.Length); i++)
                        Console.Out.Write(' ');
                    byte[] temp = new byte[end - start];
                    for (int i = start; i < end; ++i)
                    {
                        temp[i - start] = buffer[i];
                    }
                    string line = num + System.Text.Encoding.UTF8.GetString(temp);
                    Console.Out.WriteLine(line);
                }
            }
            else
                throw new UnknownStreamType("Unknown stream type " +
                                            prs_stream.getLexStream().GetType().ToString());
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
                                  oldBuffer[element.getOlde()].getStartLine() +
                                  " " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNews()].getStartLine() +
                                  (newBuffer[element.getNewe()].getEndLine() >
                                   newBuffer[element.getNews()].getStartLine()
                                      ? (".." + newBuffer[element.getNewe()].getEndLine())
                                      : "") +
                                  ":");
            printLines(newStream, newBuffer[element.getNews()].getStartLine(),
                newBuffer[element.getNewe()].getEndLine());
        }

        //
        //
        //
        public override void outputDelete(Change element)
        {
            deleteCount += (element.getOlde() - element.getOlds() + 1);
            Console.Out.WriteLine("Delete after " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNewe()].getStartLine() +
                                  " " +
                                  oldStream.getFileName() +
                                  "," +
                                  oldBuffer[element.getOlds()].getStartLine() +
                                  (oldBuffer[element.getOlde()].getEndLine() >
                                   oldBuffer[element.getOlds()].getStartLine()
                                      ? (".." + oldBuffer[element.getOlde()].getEndLine())
                                      : "") +
                                  ":");
            printLines(oldStream, oldBuffer[element.getOlds()].getStartLine(),
                oldBuffer[element.getOlde()].getEndLine());
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
                                  oldBuffer[element.getOlds()].getStartLine() +
                                  (oldBuffer[element.getOlde()].getEndLine() >
                                   oldBuffer[element.getOlds()].getStartLine()
                                      ? (".." + oldBuffer[element.getOlde()].getEndLine())
                                      : "") +
                                  ":");
            printLines(oldStream, oldBuffer[element.getOlds()].getStartLine(),
                oldBuffer[element.getOlde()].getEndLine());

            Console.Out.WriteLine("With " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNews()].getStartLine() +
                                  (newBuffer[element.getNewe()].getEndLine() >
                                   newBuffer[element.getNews()].getStartLine()
                                      ? (".." + newBuffer[element.getNewe()].getEndLine())
                                      : "") +
                                  ":");
            printLines(newStream, newBuffer[element.getNews()].getStartLine(),
                newBuffer[element.getNewe()].getEndLine());
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
                                  oldBuffer[element.getOlds()].getStartLine() +
                                  (oldBuffer[element.getOlde()].getEndLine() >
                                   oldBuffer[element.getOlds()].getStartLine()
                                      ? (".." + oldBuffer[element.getOlde()].getEndLine())
                                      : "") +
                                  " to " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNews()].getStartLine() +
                                  (newBuffer[element.getNewe()].getEndLine() >
                                   newBuffer[element.getNews()].getStartLine()
                                      ? (".." + newBuffer[element.getNewe()].getEndLine())
                                      : "") +
                                  ":");
            printLines(newStream, newBuffer[element.getNews()].getStartLine(),
                newBuffer[element.getNewe()].getEndLine());
        }

        //
        //
        //
        public override void outputMoveDelete(Change element)
        {
            moveCount += (element.getNewe() - element.getNews() + 1);
            int bound = newBuffer[element.getNewe()].getEndLine() - newBuffer[element.getNews()].getStartLine();
            Console.Out.WriteLine("Move " +
                                  oldStream.getFileName() +
                                  "," +
                                  oldBuffer[element.getOlds()].getStartLine() +
                                  (bound > 0 ? (".." + (oldBuffer[element.getOlds()].getStartLine() + bound)) : "") +
                                  " to " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNews()].getStartLine() +
                                  (newBuffer[element.getNewe()].getEndLine() >
                                   newBuffer[element.getNews()].getStartLine()
                                      ? (".." + newBuffer[element.getNewe()].getEndLine())
                                      : "") +
                                  ":");
            printLines(newStream, newBuffer[element.getNews()].getStartLine(),
                newBuffer[element.getNewe()].getEndLine());

            int oldi = oldBuffer[element.getOlds()].getStartLine() + bound + 1;
            deleteCount += (element.getOlde() - element.getOlds() - element.getNewe() + element.getNews());
            Console.Out.WriteLine("... And delete " +
                                  oldStream.getFileName() +
                                  "," +
                                  oldi +
                                  (oldBuffer[element.getOlde()].getEndLine() > oldi
                                      ? (".." + oldBuffer[element.getOlde()].getEndLine())
                                      : ""));
            printLines(oldStream, oldi, newBuffer[element.getOlde()].getEndLine());
        }

        //
        //
        //
        public override void outputMoveInsert(Change element)
        {
            moveCount += (element.getOlde() - element.getOlds() + 1);
            int bound = oldBuffer[element.getOlde()].getStartLine() - oldBuffer[element.getOlds()].getEndLine();
            Console.Out.WriteLine("Move " +
                                  oldStream.getFileName() +
                                  "," +
                                  oldBuffer[element.getOlds()].getStartLine() +
                                  (oldBuffer[element.getOlde()].getEndLine() >
                                   oldBuffer[element.getOlds()].getStartLine()
                                      ? (".." + oldBuffer[element.getOlde()].getEndLine())
                                      : "") +
                                  " to " +
                                  newStream.getFileName() +
                                  "," +
                                  newBuffer[element.getNews()].getStartLine() +
                                  (bound > 0 ? (".." + newBuffer[element.getNews()].getStartLine() + bound) : "") +
                                  ":");
            printLines(newStream, newBuffer[element.getNews()].getStartLine(),
                newBuffer[element.getNews()].getStartLine() + bound);

            int newi = newBuffer[element.getNews()].getStartLine() + bound + 1;
            insertCount += (element.getNewe() - element.getNews() - element.getOlde() + element.getOlds());
            Console.Out.WriteLine("... And insert " +
                                  newStream.getFileName() +
                                  "," +
                                  newi +
                                  (newBuffer[element.getNewe()].getEndLine() > newi
                                      ? (".." + newBuffer[element.getNewe()].getEndLine())
                                      : "") +
                                  ":");
            printLines(newStream, newi, newBuffer[element.getNewe()].getEndLine());
        }
    }
}
