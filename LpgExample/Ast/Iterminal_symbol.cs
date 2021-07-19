namespace LpgExample.Ast
{

/**
 * is always implemented by <b>ASTNodeToken</b>. It is also implemented by:
 *<b>
 *<ul>
 *<li>terminal_symbol0
 *<li>terminal_symbol1
 *</ul>
 *</b>
 */
public interface Iterminal_symbol : Ieol_segment, Ieof_segment, Ierror_segment, Iidentifier_segment, IkeywordSpec, IASTNodeToken {}

}

