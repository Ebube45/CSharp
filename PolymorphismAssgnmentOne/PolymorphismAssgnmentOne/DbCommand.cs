using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssgnmentOne
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        public string Instruction { get; }

        public DbCommand(DbConnection connection, string instruction)
        {
            // Validate the connection argument.
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));

            // Validate the instruction argument.
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction cannot be null or empty.", nameof(instruction));

            Instruction = instruction;
        }

        // Executes the command by opening the connection, running the instruction, and closing the connection.
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Executing command: " + Instruction);
            _connection.Close();
        }
    }
}
