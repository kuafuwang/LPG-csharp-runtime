namespace LPG2.Runtime
{

public class  ParseErrorCodes
{
    public   const int  LEX_ERROR_CODE = 0,
                             ERROR_CODE = 1,
                             BEFORE_CODE = 2,
                             INSERTION_CODE = 3,
                             INVALID_CODE = 4,
                             SUBSTITUTION_CODE = 5,
                             SECONDARY_CODE = 5,
                             DELETION_CODE = 6,
                             MERGE_CODE = 7,
                             MISPLACED_CODE = 8,
                             SCOPE_CODE = 9,
                             EOF_CODE = 10,
                             INVALID_TOKEN_CODE = 11,
                             ERROR_RULE_ERROR_CODE = 11,
                             ERROR_RULE_WARNING_CODE = 12,
                             NO_MESSAGE_CODE = 13;

    public  static string[] errorMsgText= {
        /* LEX_ERROR_CODE */                       ("ParseErrorCodes.LEX_ERROR_CODE"), //$NON-NLS-1$
        /* ERROR_CODE */                           ("ParseErrorCodes.ERROR_CODE"), //$NON-NLS-1$
        /* BEFORE_CODE */                          ("ParseErrorCodes.BEFORE_CODE"), //$NON-NLS-1$
        /* INSERTION_CODE */                       ("ParseErrorCodes.INSERTION_CODE"), //$NON-NLS-1$
        /* INVALID_CODE */                         ("ParseErrorCodes.INVALID_CODE"), //$NON-NLS-1$
        /* SUBSTITUTION_CODE, SECONDARY_CODE */    ("ParseErrorCodes.SUBSTITUTION_CODE"), //$NON-NLS-1$
        /* DELETION_CODE */                        ("ParseErrorCodes.DELETION_CODE"), //$NON-NLS-1$
        /* MERGE_CODE */                           ("ParseErrorCodes.MERGE_CODE"), //$NON-NLS-1$
        /* MISPLACED_CODE */                       ("ParseErrorCodes.MISPLACED_CODE"), //$NON-NLS-1$
        /* SCOPE_CODE */                           ("ParseErrorCodes.SCOPE_CODE"), //$NON-NLS-1$
        /* EOF_CODE */                             ("ParseErrorCodes.EOF_CODE"), //$NON-NLS-1$
        /* INVALID_TOKEN_CODE, ERROR_RULE_ERROR */ ("ParseErrorCodes.INVALID_TOKEN_CODE"), //$NON-NLS-1$
        /* ERROR_RULE_WARNING */                   ("ParseErrorCodes.ERROR_RULE_WARNING"), //$NON-NLS-1$
        /* NO_MESSAGE_CODE */                      ("ParseErrorCodes.NO_MESSAGE_CODE") //$NON-NLS-1$
    };

}


}
        
