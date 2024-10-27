namespace Challenge;

/// <summary>
/// A briefcase has a 4-digit lock. Each digit is a number from 0 to 9 that can be rolled either forwards or backwards.
/// Given the current code on a briefcase and the target code to unlock it, return the minimum number of turns
/// necessary to unlock the briefcase.<br />
///
/// To illustrate:<br />
/// The current lock is '0000' and the target lock is '9001'. The minimum number of turns required is 2.<br />
///
/// <b>Input constraints:</b> two <c>string</c> of 4 digits each.<br />
///
/// Output examples:
/// <code>
///     var bc = new BriefcaseLock();
///     bc.TurnsRequired("0000", "0000"); // expected 0
///     bc.TurnsRequired("0000", "1000"); // expected 1
///     bc.TurnsRequired("0000", "9001"); // expected 2
///     bc.TurnsRequired("4089", "5672"); // expected 9
/// </code>
/// </summary>
public class BriefcaseLock
{
    public int TurnsRequired(string current, string target)
    {
        /*** TODO: Implement me! */
        throw new NotImplementedException();
    }
}
