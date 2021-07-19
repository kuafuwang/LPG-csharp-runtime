namespace LpgExample.Ast
{

public abstract class AbstractVisitor : Visitor, ArgumentVisitor
{
    public abstract void unimplementedVisitor(string s);

    public void visit(ASTNodeToken n) { unimplementedVisitor("visit(ASTNodeToken)"); }
    public void visit(ASTNodeToken n, object o) { unimplementedVisitor("visit(ASTNodeToken, object)"); }

    public void visit(LPG n) { unimplementedVisitor("visit(LPG)"); }
    public void visit(LPG n, object o) { unimplementedVisitor("visit(LPG, object)"); }

    public void visit(LPG_itemList n) { unimplementedVisitor("visit(LPG_itemList)"); }
    public void visit(LPG_itemList n, object o) { unimplementedVisitor("visit(LPG_itemList, object)"); }

    public void visit(AliasSeg n) { unimplementedVisitor("visit(AliasSeg)"); }
    public void visit(AliasSeg n, object o) { unimplementedVisitor("visit(AliasSeg, object)"); }

    public void visit(AstSeg n) { unimplementedVisitor("visit(AstSeg)"); }
    public void visit(AstSeg n, object o) { unimplementedVisitor("visit(AstSeg, object)"); }

    public void visit(DefineSeg n) { unimplementedVisitor("visit(DefineSeg)"); }
    public void visit(DefineSeg n, object o) { unimplementedVisitor("visit(DefineSeg, object)"); }

    public void visit(EofSeg n) { unimplementedVisitor("visit(EofSeg)"); }
    public void visit(EofSeg n, object o) { unimplementedVisitor("visit(EofSeg, object)"); }

    public void visit(EolSeg n) { unimplementedVisitor("visit(EolSeg)"); }
    public void visit(EolSeg n, object o) { unimplementedVisitor("visit(EolSeg, object)"); }

    public void visit(ErrorSeg n) { unimplementedVisitor("visit(ErrorSeg)"); }
    public void visit(ErrorSeg n, object o) { unimplementedVisitor("visit(ErrorSeg, object)"); }

    public void visit(ExportSeg n) { unimplementedVisitor("visit(ExportSeg)"); }
    public void visit(ExportSeg n, object o) { unimplementedVisitor("visit(ExportSeg, object)"); }

    public void visit(GlobalsSeg n) { unimplementedVisitor("visit(GlobalsSeg)"); }
    public void visit(GlobalsSeg n, object o) { unimplementedVisitor("visit(GlobalsSeg, object)"); }

    public void visit(HeadersSeg n) { unimplementedVisitor("visit(HeadersSeg)"); }
    public void visit(HeadersSeg n, object o) { unimplementedVisitor("visit(HeadersSeg, object)"); }

    public void visit(IdentifierSeg n) { unimplementedVisitor("visit(IdentifierSeg)"); }
    public void visit(IdentifierSeg n, object o) { unimplementedVisitor("visit(IdentifierSeg, object)"); }

    public void visit(ImportSeg n) { unimplementedVisitor("visit(ImportSeg)"); }
    public void visit(ImportSeg n, object o) { unimplementedVisitor("visit(ImportSeg, object)"); }

    public void visit(IncludeSeg n) { unimplementedVisitor("visit(IncludeSeg)"); }
    public void visit(IncludeSeg n, object o) { unimplementedVisitor("visit(IncludeSeg, object)"); }

    public void visit(KeywordsSeg n) { unimplementedVisitor("visit(KeywordsSeg)"); }
    public void visit(KeywordsSeg n, object o) { unimplementedVisitor("visit(KeywordsSeg, object)"); }

    public void visit(NamesSeg n) { unimplementedVisitor("visit(NamesSeg)"); }
    public void visit(NamesSeg n, object o) { unimplementedVisitor("visit(NamesSeg, object)"); }

    public void visit(NoticeSeg n) { unimplementedVisitor("visit(NoticeSeg)"); }
    public void visit(NoticeSeg n, object o) { unimplementedVisitor("visit(NoticeSeg, object)"); }

    public void visit(RulesSeg n) { unimplementedVisitor("visit(RulesSeg)"); }
    public void visit(RulesSeg n, object o) { unimplementedVisitor("visit(RulesSeg, object)"); }

    public void visit(SoftKeywordsSeg n) { unimplementedVisitor("visit(SoftKeywordsSeg)"); }
    public void visit(SoftKeywordsSeg n, object o) { unimplementedVisitor("visit(SoftKeywordsSeg, object)"); }

    public void visit(StartSeg n) { unimplementedVisitor("visit(StartSeg)"); }
    public void visit(StartSeg n, object o) { unimplementedVisitor("visit(StartSeg, object)"); }

    public void visit(TerminalsSeg n) { unimplementedVisitor("visit(TerminalsSeg)"); }
    public void visit(TerminalsSeg n, object o) { unimplementedVisitor("visit(TerminalsSeg, object)"); }

    public void visit(TrailersSeg n) { unimplementedVisitor("visit(TrailersSeg)"); }
    public void visit(TrailersSeg n, object o) { unimplementedVisitor("visit(TrailersSeg, object)"); }

    public void visit(TypesSeg n) { unimplementedVisitor("visit(TypesSeg)"); }
    public void visit(TypesSeg n, object o) { unimplementedVisitor("visit(TypesSeg, object)"); }

    public void visit(RecoverSeg n) { unimplementedVisitor("visit(RecoverSeg)"); }
    public void visit(RecoverSeg n, object o) { unimplementedVisitor("visit(RecoverSeg, object)"); }

    public void visit(PredecessorSeg n) { unimplementedVisitor("visit(PredecessorSeg)"); }
    public void visit(PredecessorSeg n, object o) { unimplementedVisitor("visit(PredecessorSeg, object)"); }

    public void visit(option_specList n) { unimplementedVisitor("visit(option_specList)"); }
    public void visit(option_specList n, object o) { unimplementedVisitor("visit(option_specList, object)"); }

    public void visit(option_spec n) { unimplementedVisitor("visit(option_spec)"); }
    public void visit(option_spec n, object o) { unimplementedVisitor("visit(option_spec, object)"); }

    public void visit(optionList n) { unimplementedVisitor("visit(optionList)"); }
    public void visit(optionList n, object o) { unimplementedVisitor("visit(optionList, object)"); }

    public void visit(option n) { unimplementedVisitor("visit(option)"); }
    public void visit(option n, object o) { unimplementedVisitor("visit(option, object)"); }

    public void visit(SYMBOLList n) { unimplementedVisitor("visit(SYMBOLList)"); }
    public void visit(SYMBOLList n, object o) { unimplementedVisitor("visit(SYMBOLList, object)"); }

    public void visit(aliasSpecList n) { unimplementedVisitor("visit(aliasSpecList)"); }
    public void visit(aliasSpecList n, object o) { unimplementedVisitor("visit(aliasSpecList, object)"); }

    public void visit(alias_lhs_macro_name n) { unimplementedVisitor("visit(alias_lhs_macro_name)"); }
    public void visit(alias_lhs_macro_name n, object o) { unimplementedVisitor("visit(alias_lhs_macro_name, object)"); }

    public void visit(defineSpecList n) { unimplementedVisitor("visit(defineSpecList)"); }
    public void visit(defineSpecList n, object o) { unimplementedVisitor("visit(defineSpecList, object)"); }

    public void visit(defineSpec n) { unimplementedVisitor("visit(defineSpec)"); }
    public void visit(defineSpec n, object o) { unimplementedVisitor("visit(defineSpec, object)"); }

    public void visit(macro_segment n) { unimplementedVisitor("visit(macro_segment)"); }
    public void visit(macro_segment n, object o) { unimplementedVisitor("visit(macro_segment, object)"); }

    public void visit(terminal_symbolList n) { unimplementedVisitor("visit(terminal_symbolList)"); }
    public void visit(terminal_symbolList n, object o) { unimplementedVisitor("visit(terminal_symbolList, object)"); }

    public void visit(action_segmentList n) { unimplementedVisitor("visit(action_segmentList)"); }
    public void visit(action_segmentList n, object o) { unimplementedVisitor("visit(action_segmentList, object)"); }

    public void visit(import_segment n) { unimplementedVisitor("visit(import_segment)"); }
    public void visit(import_segment n, object o) { unimplementedVisitor("visit(import_segment, object)"); }

    public void visit(drop_commandList n) { unimplementedVisitor("visit(drop_commandList)"); }
    public void visit(drop_commandList n, object o) { unimplementedVisitor("visit(drop_commandList, object)"); }

    public void visit(drop_ruleList n) { unimplementedVisitor("visit(drop_ruleList)"); }
    public void visit(drop_ruleList n, object o) { unimplementedVisitor("visit(drop_ruleList, object)"); }

    public void visit(drop_rule n) { unimplementedVisitor("visit(drop_rule)"); }
    public void visit(drop_rule n, object o) { unimplementedVisitor("visit(drop_rule, object)"); }

    public void visit(optMacroName n) { unimplementedVisitor("visit(optMacroName)"); }
    public void visit(optMacroName n, object o) { unimplementedVisitor("visit(optMacroName, object)"); }

    public void visit(include_segment n) { unimplementedVisitor("visit(include_segment)"); }
    public void visit(include_segment n, object o) { unimplementedVisitor("visit(include_segment, object)"); }

    public void visit(keywordSpecList n) { unimplementedVisitor("visit(keywordSpecList)"); }
    public void visit(keywordSpecList n, object o) { unimplementedVisitor("visit(keywordSpecList, object)"); }

    public void visit(keywordSpec n) { unimplementedVisitor("visit(keywordSpec)"); }
    public void visit(keywordSpec n, object o) { unimplementedVisitor("visit(keywordSpec, object)"); }

    public void visit(nameSpecList n) { unimplementedVisitor("visit(nameSpecList)"); }
    public void visit(nameSpecList n, object o) { unimplementedVisitor("visit(nameSpecList, object)"); }

    public void visit(nameSpec n) { unimplementedVisitor("visit(nameSpec)"); }
    public void visit(nameSpec n, object o) { unimplementedVisitor("visit(nameSpec, object)"); }

    public void visit(rules_segment n) { unimplementedVisitor("visit(rules_segment)"); }
    public void visit(rules_segment n, object o) { unimplementedVisitor("visit(rules_segment, object)"); }

    public void visit(nonTermList n) { unimplementedVisitor("visit(nonTermList)"); }
    public void visit(nonTermList n, object o) { unimplementedVisitor("visit(nonTermList, object)"); }

    public void visit(nonTerm n) { unimplementedVisitor("visit(nonTerm)"); }
    public void visit(nonTerm n, object o) { unimplementedVisitor("visit(nonTerm, object)"); }

    public void visit(RuleName n) { unimplementedVisitor("visit(RuleName)"); }
    public void visit(RuleName n, object o) { unimplementedVisitor("visit(RuleName, object)"); }

    public void visit(ruleList n) { unimplementedVisitor("visit(ruleList)"); }
    public void visit(ruleList n, object o) { unimplementedVisitor("visit(ruleList, object)"); }

    public void visit(rule n) { unimplementedVisitor("visit(rule)"); }
    public void visit(rule n, object o) { unimplementedVisitor("visit(rule, object)"); }

    public void visit(symWithAttrsList n) { unimplementedVisitor("visit(symWithAttrsList)"); }
    public void visit(symWithAttrsList n, object o) { unimplementedVisitor("visit(symWithAttrsList, object)"); }

    public void visit(symAttrs n) { unimplementedVisitor("visit(symAttrs)"); }
    public void visit(symAttrs n, object o) { unimplementedVisitor("visit(symAttrs, object)"); }

    public void visit(action_segment n) { unimplementedVisitor("visit(action_segment)"); }
    public void visit(action_segment n, object o) { unimplementedVisitor("visit(action_segment, object)"); }

    public void visit(start_symbolList n) { unimplementedVisitor("visit(start_symbolList)"); }
    public void visit(start_symbolList n, object o) { unimplementedVisitor("visit(start_symbolList, object)"); }

    public void visit(terminalList n) { unimplementedVisitor("visit(terminalList)"); }
    public void visit(terminalList n, object o) { unimplementedVisitor("visit(terminalList, object)"); }

    public void visit(terminal n) { unimplementedVisitor("visit(terminal)"); }
    public void visit(terminal n, object o) { unimplementedVisitor("visit(terminal, object)"); }

    public void visit(optTerminalAlias n) { unimplementedVisitor("visit(optTerminalAlias)"); }
    public void visit(optTerminalAlias n, object o) { unimplementedVisitor("visit(optTerminalAlias, object)"); }

    public void visit(type_declarationsList n) { unimplementedVisitor("visit(type_declarationsList)"); }
    public void visit(type_declarationsList n, object o) { unimplementedVisitor("visit(type_declarationsList, object)"); }

    public void visit(type_declarations n) { unimplementedVisitor("visit(type_declarations)"); }
    public void visit(type_declarations n, object o) { unimplementedVisitor("visit(type_declarations, object)"); }

    public void visit(symbol_pairList n) { unimplementedVisitor("visit(symbol_pairList)"); }
    public void visit(symbol_pairList n, object o) { unimplementedVisitor("visit(symbol_pairList, object)"); }

    public void visit(symbol_pair n) { unimplementedVisitor("visit(symbol_pair)"); }
    public void visit(symbol_pair n, object o) { unimplementedVisitor("visit(symbol_pair, object)"); }

    public void visit(recover_symbol n) { unimplementedVisitor("visit(recover_symbol)"); }
    public void visit(recover_symbol n, object o) { unimplementedVisitor("visit(recover_symbol, object)"); }

    public void visit(END_KEY_OPT n) { unimplementedVisitor("visit(END_KEY_OPT)"); }
    public void visit(END_KEY_OPT n, object o) { unimplementedVisitor("visit(END_KEY_OPT, object)"); }

    public void visit(option_value0 n) { unimplementedVisitor("visit(option_value0)"); }
    public void visit(option_value0 n, object o) { unimplementedVisitor("visit(option_value0, object)"); }

    public void visit(option_value1 n) { unimplementedVisitor("visit(option_value1)"); }
    public void visit(option_value1 n, object o) { unimplementedVisitor("visit(option_value1, object)"); }

    public void visit(aliasSpec0 n) { unimplementedVisitor("visit(aliasSpec0)"); }
    public void visit(aliasSpec0 n, object o) { unimplementedVisitor("visit(aliasSpec0, object)"); }

    public void visit(aliasSpec1 n) { unimplementedVisitor("visit(aliasSpec1)"); }
    public void visit(aliasSpec1 n, object o) { unimplementedVisitor("visit(aliasSpec1, object)"); }

    public void visit(aliasSpec2 n) { unimplementedVisitor("visit(aliasSpec2)"); }
    public void visit(aliasSpec2 n, object o) { unimplementedVisitor("visit(aliasSpec2, object)"); }

    public void visit(aliasSpec3 n) { unimplementedVisitor("visit(aliasSpec3)"); }
    public void visit(aliasSpec3 n, object o) { unimplementedVisitor("visit(aliasSpec3, object)"); }

    public void visit(aliasSpec4 n) { unimplementedVisitor("visit(aliasSpec4)"); }
    public void visit(aliasSpec4 n, object o) { unimplementedVisitor("visit(aliasSpec4, object)"); }

    public void visit(aliasSpec5 n) { unimplementedVisitor("visit(aliasSpec5)"); }
    public void visit(aliasSpec5 n, object o) { unimplementedVisitor("visit(aliasSpec5, object)"); }

    public void visit(alias_rhs0 n) { unimplementedVisitor("visit(alias_rhs0)"); }
    public void visit(alias_rhs0 n, object o) { unimplementedVisitor("visit(alias_rhs0, object)"); }

    public void visit(alias_rhs1 n) { unimplementedVisitor("visit(alias_rhs1)"); }
    public void visit(alias_rhs1 n, object o) { unimplementedVisitor("visit(alias_rhs1, object)"); }

    public void visit(alias_rhs2 n) { unimplementedVisitor("visit(alias_rhs2)"); }
    public void visit(alias_rhs2 n, object o) { unimplementedVisitor("visit(alias_rhs2, object)"); }

    public void visit(alias_rhs3 n) { unimplementedVisitor("visit(alias_rhs3)"); }
    public void visit(alias_rhs3 n, object o) { unimplementedVisitor("visit(alias_rhs3, object)"); }

    public void visit(alias_rhs4 n) { unimplementedVisitor("visit(alias_rhs4)"); }
    public void visit(alias_rhs4 n, object o) { unimplementedVisitor("visit(alias_rhs4, object)"); }

    public void visit(alias_rhs5 n) { unimplementedVisitor("visit(alias_rhs5)"); }
    public void visit(alias_rhs5 n, object o) { unimplementedVisitor("visit(alias_rhs5, object)"); }

    public void visit(alias_rhs6 n) { unimplementedVisitor("visit(alias_rhs6)"); }
    public void visit(alias_rhs6 n, object o) { unimplementedVisitor("visit(alias_rhs6, object)"); }

    public void visit(macro_name_symbol0 n) { unimplementedVisitor("visit(macro_name_symbol0)"); }
    public void visit(macro_name_symbol0 n, object o) { unimplementedVisitor("visit(macro_name_symbol0, object)"); }

    public void visit(macro_name_symbol1 n) { unimplementedVisitor("visit(macro_name_symbol1)"); }
    public void visit(macro_name_symbol1 n, object o) { unimplementedVisitor("visit(macro_name_symbol1, object)"); }

    public void visit(drop_command0 n) { unimplementedVisitor("visit(drop_command0)"); }
    public void visit(drop_command0 n, object o) { unimplementedVisitor("visit(drop_command0, object)"); }

    public void visit(drop_command1 n) { unimplementedVisitor("visit(drop_command1)"); }
    public void visit(drop_command1 n, object o) { unimplementedVisitor("visit(drop_command1, object)"); }

    public void visit(name0 n) { unimplementedVisitor("visit(name0)"); }
    public void visit(name0 n, object o) { unimplementedVisitor("visit(name0, object)"); }

    public void visit(name1 n) { unimplementedVisitor("visit(name1)"); }
    public void visit(name1 n, object o) { unimplementedVisitor("visit(name1, object)"); }

    public void visit(name2 n) { unimplementedVisitor("visit(name2)"); }
    public void visit(name2 n, object o) { unimplementedVisitor("visit(name2, object)"); }

    public void visit(name3 n) { unimplementedVisitor("visit(name3)"); }
    public void visit(name3 n, object o) { unimplementedVisitor("visit(name3, object)"); }

    public void visit(name4 n) { unimplementedVisitor("visit(name4)"); }
    public void visit(name4 n, object o) { unimplementedVisitor("visit(name4, object)"); }

    public void visit(name5 n) { unimplementedVisitor("visit(name5)"); }
    public void visit(name5 n, object o) { unimplementedVisitor("visit(name5, object)"); }

    public void visit(produces0 n) { unimplementedVisitor("visit(produces0)"); }
    public void visit(produces0 n, object o) { unimplementedVisitor("visit(produces0, object)"); }

    public void visit(produces1 n) { unimplementedVisitor("visit(produces1)"); }
    public void visit(produces1 n, object o) { unimplementedVisitor("visit(produces1, object)"); }

    public void visit(produces2 n) { unimplementedVisitor("visit(produces2)"); }
    public void visit(produces2 n, object o) { unimplementedVisitor("visit(produces2, object)"); }

    public void visit(produces3 n) { unimplementedVisitor("visit(produces3)"); }
    public void visit(produces3 n, object o) { unimplementedVisitor("visit(produces3, object)"); }

    public void visit(symWithAttrs0 n) { unimplementedVisitor("visit(symWithAttrs0)"); }
    public void visit(symWithAttrs0 n, object o) { unimplementedVisitor("visit(symWithAttrs0, object)"); }

    public void visit(symWithAttrs1 n) { unimplementedVisitor("visit(symWithAttrs1)"); }
    public void visit(symWithAttrs1 n, object o) { unimplementedVisitor("visit(symWithAttrs1, object)"); }

    public void visit(start_symbol0 n) { unimplementedVisitor("visit(start_symbol0)"); }
    public void visit(start_symbol0 n, object o) { unimplementedVisitor("visit(start_symbol0, object)"); }

    public void visit(start_symbol1 n) { unimplementedVisitor("visit(start_symbol1)"); }
    public void visit(start_symbol1 n, object o) { unimplementedVisitor("visit(start_symbol1, object)"); }

    public void visit(terminal_symbol0 n) { unimplementedVisitor("visit(terminal_symbol0)"); }
    public void visit(terminal_symbol0 n, object o) { unimplementedVisitor("visit(terminal_symbol0, object)"); }

    public void visit(terminal_symbol1 n) { unimplementedVisitor("visit(terminal_symbol1)"); }
    public void visit(terminal_symbol1 n, object o) { unimplementedVisitor("visit(terminal_symbol1, object)"); }


    public void visit(ASTNode n)
    {
        if (n is ASTNodeToken) visit((ASTNodeToken) n);
        else if (n is LPG) visit((LPG) n);
        else if (n is LPG_itemList) visit((LPG_itemList) n);
        else if (n is AliasSeg) visit((AliasSeg) n);
        else if (n is AstSeg) visit((AstSeg) n);
        else if (n is DefineSeg) visit((DefineSeg) n);
        else if (n is EofSeg) visit((EofSeg) n);
        else if (n is EolSeg) visit((EolSeg) n);
        else if (n is ErrorSeg) visit((ErrorSeg) n);
        else if (n is ExportSeg) visit((ExportSeg) n);
        else if (n is GlobalsSeg) visit((GlobalsSeg) n);
        else if (n is HeadersSeg) visit((HeadersSeg) n);
        else if (n is IdentifierSeg) visit((IdentifierSeg) n);
        else if (n is ImportSeg) visit((ImportSeg) n);
        else if (n is IncludeSeg) visit((IncludeSeg) n);
        else if (n is KeywordsSeg) visit((KeywordsSeg) n);
        else if (n is NamesSeg) visit((NamesSeg) n);
        else if (n is NoticeSeg) visit((NoticeSeg) n);
        else if (n is RulesSeg) visit((RulesSeg) n);
        else if (n is SoftKeywordsSeg) visit((SoftKeywordsSeg) n);
        else if (n is StartSeg) visit((StartSeg) n);
        else if (n is TerminalsSeg) visit((TerminalsSeg) n);
        else if (n is TrailersSeg) visit((TrailersSeg) n);
        else if (n is TypesSeg) visit((TypesSeg) n);
        else if (n is RecoverSeg) visit((RecoverSeg) n);
        else if (n is PredecessorSeg) visit((PredecessorSeg) n);
        else if (n is option_specList) visit((option_specList) n);
        else if (n is option_spec) visit((option_spec) n);
        else if (n is optionList) visit((optionList) n);
        else if (n is option) visit((option) n);
        else if (n is SYMBOLList) visit((SYMBOLList) n);
        else if (n is aliasSpecList) visit((aliasSpecList) n);
        else if (n is alias_lhs_macro_name) visit((alias_lhs_macro_name) n);
        else if (n is defineSpecList) visit((defineSpecList) n);
        else if (n is defineSpec) visit((defineSpec) n);
        else if (n is macro_segment) visit((macro_segment) n);
        else if (n is terminal_symbolList) visit((terminal_symbolList) n);
        else if (n is action_segmentList) visit((action_segmentList) n);
        else if (n is import_segment) visit((import_segment) n);
        else if (n is drop_commandList) visit((drop_commandList) n);
        else if (n is drop_ruleList) visit((drop_ruleList) n);
        else if (n is drop_rule) visit((drop_rule) n);
        else if (n is optMacroName) visit((optMacroName) n);
        else if (n is include_segment) visit((include_segment) n);
        else if (n is keywordSpecList) visit((keywordSpecList) n);
        else if (n is keywordSpec) visit((keywordSpec) n);
        else if (n is nameSpecList) visit((nameSpecList) n);
        else if (n is nameSpec) visit((nameSpec) n);
        else if (n is rules_segment) visit((rules_segment) n);
        else if (n is nonTermList) visit((nonTermList) n);
        else if (n is nonTerm) visit((nonTerm) n);
        else if (n is RuleName) visit((RuleName) n);
        else if (n is ruleList) visit((ruleList) n);
        else if (n is rule) visit((rule) n);
        else if (n is symWithAttrsList) visit((symWithAttrsList) n);
        else if (n is symAttrs) visit((symAttrs) n);
        else if (n is action_segment) visit((action_segment) n);
        else if (n is start_symbolList) visit((start_symbolList) n);
        else if (n is terminalList) visit((terminalList) n);
        else if (n is terminal) visit((terminal) n);
        else if (n is optTerminalAlias) visit((optTerminalAlias) n);
        else if (n is type_declarationsList) visit((type_declarationsList) n);
        else if (n is type_declarations) visit((type_declarations) n);
        else if (n is symbol_pairList) visit((symbol_pairList) n);
        else if (n is symbol_pair) visit((symbol_pair) n);
        else if (n is recover_symbol) visit((recover_symbol) n);
        else if (n is END_KEY_OPT) visit((END_KEY_OPT) n);
        else if (n is option_value0) visit((option_value0) n);
        else if (n is option_value1) visit((option_value1) n);
        else if (n is aliasSpec0) visit((aliasSpec0) n);
        else if (n is aliasSpec1) visit((aliasSpec1) n);
        else if (n is aliasSpec2) visit((aliasSpec2) n);
        else if (n is aliasSpec3) visit((aliasSpec3) n);
        else if (n is aliasSpec4) visit((aliasSpec4) n);
        else if (n is aliasSpec5) visit((aliasSpec5) n);
        else if (n is alias_rhs0) visit((alias_rhs0) n);
        else if (n is alias_rhs1) visit((alias_rhs1) n);
        else if (n is alias_rhs2) visit((alias_rhs2) n);
        else if (n is alias_rhs3) visit((alias_rhs3) n);
        else if (n is alias_rhs4) visit((alias_rhs4) n);
        else if (n is alias_rhs5) visit((alias_rhs5) n);
        else if (n is alias_rhs6) visit((alias_rhs6) n);
        else if (n is macro_name_symbol0) visit((macro_name_symbol0) n);
        else if (n is macro_name_symbol1) visit((macro_name_symbol1) n);
        else if (n is drop_command0) visit((drop_command0) n);
        else if (n is drop_command1) visit((drop_command1) n);
        else if (n is name0) visit((name0) n);
        else if (n is name1) visit((name1) n);
        else if (n is name2) visit((name2) n);
        else if (n is name3) visit((name3) n);
        else if (n is name4) visit((name4) n);
        else if (n is name5) visit((name5) n);
        else if (n is produces0) visit((produces0) n);
        else if (n is produces1) visit((produces1) n);
        else if (n is produces2) visit((produces2) n);
        else if (n is produces3) visit((produces3) n);
        else if (n is symWithAttrs0) visit((symWithAttrs0) n);
        else if (n is symWithAttrs1) visit((symWithAttrs1) n);
        else if (n is start_symbol0) visit((start_symbol0) n);
        else if (n is start_symbol1) visit((start_symbol1) n);
        else if (n is terminal_symbol0) visit((terminal_symbol0) n);
        else if (n is terminal_symbol1) visit((terminal_symbol1) n);
        throw new System.NotSupportedException("visit(" + n.GetType().ToString() + ")");
    }
    public void visit(ASTNode n, object o)
    {
        if (n is ASTNodeToken) visit((ASTNodeToken) n, o);
        else if (n is LPG) visit((LPG) n, o);
        else if (n is LPG_itemList) visit((LPG_itemList) n, o);
        else if (n is AliasSeg) visit((AliasSeg) n, o);
        else if (n is AstSeg) visit((AstSeg) n, o);
        else if (n is DefineSeg) visit((DefineSeg) n, o);
        else if (n is EofSeg) visit((EofSeg) n, o);
        else if (n is EolSeg) visit((EolSeg) n, o);
        else if (n is ErrorSeg) visit((ErrorSeg) n, o);
        else if (n is ExportSeg) visit((ExportSeg) n, o);
        else if (n is GlobalsSeg) visit((GlobalsSeg) n, o);
        else if (n is HeadersSeg) visit((HeadersSeg) n, o);
        else if (n is IdentifierSeg) visit((IdentifierSeg) n, o);
        else if (n is ImportSeg) visit((ImportSeg) n, o);
        else if (n is IncludeSeg) visit((IncludeSeg) n, o);
        else if (n is KeywordsSeg) visit((KeywordsSeg) n, o);
        else if (n is NamesSeg) visit((NamesSeg) n, o);
        else if (n is NoticeSeg) visit((NoticeSeg) n, o);
        else if (n is RulesSeg) visit((RulesSeg) n, o);
        else if (n is SoftKeywordsSeg) visit((SoftKeywordsSeg) n, o);
        else if (n is StartSeg) visit((StartSeg) n, o);
        else if (n is TerminalsSeg) visit((TerminalsSeg) n, o);
        else if (n is TrailersSeg) visit((TrailersSeg) n, o);
        else if (n is TypesSeg) visit((TypesSeg) n, o);
        else if (n is RecoverSeg) visit((RecoverSeg) n, o);
        else if (n is PredecessorSeg) visit((PredecessorSeg) n, o);
        else if (n is option_specList) visit((option_specList) n, o);
        else if (n is option_spec) visit((option_spec) n, o);
        else if (n is optionList) visit((optionList) n, o);
        else if (n is option) visit((option) n, o);
        else if (n is SYMBOLList) visit((SYMBOLList) n, o);
        else if (n is aliasSpecList) visit((aliasSpecList) n, o);
        else if (n is alias_lhs_macro_name) visit((alias_lhs_macro_name) n, o);
        else if (n is defineSpecList) visit((defineSpecList) n, o);
        else if (n is defineSpec) visit((defineSpec) n, o);
        else if (n is macro_segment) visit((macro_segment) n, o);
        else if (n is terminal_symbolList) visit((terminal_symbolList) n, o);
        else if (n is action_segmentList) visit((action_segmentList) n, o);
        else if (n is import_segment) visit((import_segment) n, o);
        else if (n is drop_commandList) visit((drop_commandList) n, o);
        else if (n is drop_ruleList) visit((drop_ruleList) n, o);
        else if (n is drop_rule) visit((drop_rule) n, o);
        else if (n is optMacroName) visit((optMacroName) n, o);
        else if (n is include_segment) visit((include_segment) n, o);
        else if (n is keywordSpecList) visit((keywordSpecList) n, o);
        else if (n is keywordSpec) visit((keywordSpec) n, o);
        else if (n is nameSpecList) visit((nameSpecList) n, o);
        else if (n is nameSpec) visit((nameSpec) n, o);
        else if (n is rules_segment) visit((rules_segment) n, o);
        else if (n is nonTermList) visit((nonTermList) n, o);
        else if (n is nonTerm) visit((nonTerm) n, o);
        else if (n is RuleName) visit((RuleName) n, o);
        else if (n is ruleList) visit((ruleList) n, o);
        else if (n is rule) visit((rule) n, o);
        else if (n is symWithAttrsList) visit((symWithAttrsList) n, o);
        else if (n is symAttrs) visit((symAttrs) n, o);
        else if (n is action_segment) visit((action_segment) n, o);
        else if (n is start_symbolList) visit((start_symbolList) n, o);
        else if (n is terminalList) visit((terminalList) n, o);
        else if (n is terminal) visit((terminal) n, o);
        else if (n is optTerminalAlias) visit((optTerminalAlias) n, o);
        else if (n is type_declarationsList) visit((type_declarationsList) n, o);
        else if (n is type_declarations) visit((type_declarations) n, o);
        else if (n is symbol_pairList) visit((symbol_pairList) n, o);
        else if (n is symbol_pair) visit((symbol_pair) n, o);
        else if (n is recover_symbol) visit((recover_symbol) n, o);
        else if (n is END_KEY_OPT) visit((END_KEY_OPT) n, o);
        else if (n is option_value0) visit((option_value0) n, o);
        else if (n is option_value1) visit((option_value1) n, o);
        else if (n is aliasSpec0) visit((aliasSpec0) n, o);
        else if (n is aliasSpec1) visit((aliasSpec1) n, o);
        else if (n is aliasSpec2) visit((aliasSpec2) n, o);
        else if (n is aliasSpec3) visit((aliasSpec3) n, o);
        else if (n is aliasSpec4) visit((aliasSpec4) n, o);
        else if (n is aliasSpec5) visit((aliasSpec5) n, o);
        else if (n is alias_rhs0) visit((alias_rhs0) n, o);
        else if (n is alias_rhs1) visit((alias_rhs1) n, o);
        else if (n is alias_rhs2) visit((alias_rhs2) n, o);
        else if (n is alias_rhs3) visit((alias_rhs3) n, o);
        else if (n is alias_rhs4) visit((alias_rhs4) n, o);
        else if (n is alias_rhs5) visit((alias_rhs5) n, o);
        else if (n is alias_rhs6) visit((alias_rhs6) n, o);
        else if (n is macro_name_symbol0) visit((macro_name_symbol0) n, o);
        else if (n is macro_name_symbol1) visit((macro_name_symbol1) n, o);
        else if (n is drop_command0) visit((drop_command0) n, o);
        else if (n is drop_command1) visit((drop_command1) n, o);
        else if (n is name0) visit((name0) n, o);
        else if (n is name1) visit((name1) n, o);
        else if (n is name2) visit((name2) n, o);
        else if (n is name3) visit((name3) n, o);
        else if (n is name4) visit((name4) n, o);
        else if (n is name5) visit((name5) n, o);
        else if (n is produces0) visit((produces0) n, o);
        else if (n is produces1) visit((produces1) n, o);
        else if (n is produces2) visit((produces2) n, o);
        else if (n is produces3) visit((produces3) n, o);
        else if (n is symWithAttrs0) visit((symWithAttrs0) n, o);
        else if (n is symWithAttrs1) visit((symWithAttrs1) n, o);
        else if (n is start_symbol0) visit((start_symbol0) n, o);
        else if (n is start_symbol1) visit((start_symbol1) n, o);
        else if (n is terminal_symbol0) visit((terminal_symbol0) n, o);
        else if (n is terminal_symbol1) visit((terminal_symbol1) n, o);
        throw new System.NotSupportedException("visit(" + n.GetType().ToString() + ")");
    }
}
}

