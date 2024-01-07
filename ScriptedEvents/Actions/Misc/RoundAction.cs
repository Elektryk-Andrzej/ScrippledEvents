namespace ScriptedEvents.Actions
{
    using System.Linq;

    using ScriptedEvents.API.Enums;
    using ScriptedEvents.API.Features;
    using ScriptedEvents.API.Interfaces;
    using ScriptedEvents.Structures;
    using ScriptedEvents.Variables;
    using ScriptedEvents.Variables.Interfaces;

    public class RoundAction : IScriptAction, IHelpInfo
    {
        /// <inheritdoc/>
        public string Name => "ROUND";

        /// <inheritdoc/>
        public string[] Aliases => Array.Empty<string>();

        /// <inheritdoc/>
        public string[] Arguments { get; set; }

        /// <inheritdoc/>
        public ActionSubgroup Subgroup => ActionSubgroup.Misc;

        /// <inheritdoc/>
        public string Description => "Rounds a floating point variable to an integer variable.";

        /// <inheritdoc/>
        public Argument[] ExpectedArguments => new[]
        {
            new Argument("variableName", typeof(string), "The name of the new variable.", true),
            new Argument("roundOption", typeof(string), "The way of rounding the variable. Either UP or DOWN.", true),
        };

        /// <inheritdoc/>
        public ActionResponse Execute(Script script)
        {
            if (Arguments.Length != 3) return new(MessageType.InvalidUsage, this, null, (object)ExpectedArguments);

            string baseVarName = Arguments[0];
            string inputVarName = Arguments[1];
            string mode = Arguments[2];

            inputVarName = VariableSystem.ReplaceVariables(inputVarName, script);

            try
            {
                VariableSystem.TryGetVariable(inputVarName, out IConditionVariable variable, out _, script, true);
                VariableSystem.
            }
            catch 
            { 
            }

            VariableSystem.DefineVariable(varName, "User-defined variable.", input, script);

            VariableSystem.RemoveVariable();

            return new(true);
        }
    }
}
