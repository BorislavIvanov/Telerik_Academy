using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class HTMLTable : HTMLElement, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] cell;

        public HTMLTable(int rows, int cols)
            : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cell = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Row value is negative!!!");
                }
                else
                {
                    this.rows = value;
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Col value is negative!!!");
                }
                else
                {
                    this.cols = value;
                }
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                if (row < 0 && row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Index row is out of range!!!");
                }

                if (col < 0 && col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Index col is out of range!!!");
                }

                return this.cell[row, col];
            }
            set
            {
                if (row < 0 && row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Index row is out of range!!!");
                }

                if (col < 0 && col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Index col is out of range!!!");
                }

                if (value == null)
                {
                    throw new ArgumentException("The Value cant be \"null\"");
                }

                this.cell[row, col] = value;
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("Tables cannot have text content");
            }
            set
            {
                throw new InvalidOperationException("Tables cannot have text content");
            }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");

                    output.Append(this.cell[row, col].ToString());

                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", this.Name);
        }
    }
}
