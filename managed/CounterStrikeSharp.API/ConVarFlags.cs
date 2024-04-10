/*
 *  This file is part of CounterStrikeSharp.
 *  CounterStrikeSharp is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CounterStrikeSharp is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CounterStrikeSharp.  If not, see <https://www.gnu.org/licenses/>. *
 */

namespace CounterStrikeSharp.API;

[Flags]
public enum ConVarFlags : Int64
{
    FCVAR_NONE = 0,
    FCVAR_LINKED_CONCOMMAND = (1 << 0),

    FCVAR_DEVELOPMENTONLY =
        (1 << 1), // Hidden in released products. Flag is removed automatically if ALLOW_DEVELOPMENT_CVARS is defined.
    FCVAR_GAMEDLL = (1 << 2), // defined by the game DLL
    FCVAR_CLIENTDLL = (1 << 3), // defined by the client DLL

    FCVAR_HIDDEN =
        (1 << 4), // Hidden. Doesn't appear in find or auto complete. Like DEVELOPMENTONLY, but can't be compiled out.

    // ConVar only
    FCVAR_PROTECTED =
        (1 << 5), // It's a server cvar, but we don't send the data since it's a password, etc.  Sends 1 if it's not bland/zero, 0 otherwise as value
    FCVAR_SPONLY = (1 << 6), // This cvar cannot be changed by clients connected to a multiplayer server.
    FCVAR_ARCHIVE = (1 << 7), // set to cause it to be saved to vars.rc
    FCVAR_NOTIFY = (1 << 8), // notifies players when changed
    FCVAR_USERINFO = (1 << 9), // changes the client's info string
    FCVAR_MISSING0 = (1 << 10), // Something that hides the cvar from the cvar lookups

    FCVAR_UNLOGGED =
        (1 << 11), // If this is a FCVAR_SERVER, don't log changes to the log file / console if we are creating a log
    FCVAR_MISSING1 = (1 << 12), // Something that hides the cvar from the cvar lookups
    FCVAR_REPLICATED = (1 << 13), // server setting enforced on clients, TODO rename to FCAR_SERVER at some time
    FCVAR_CHEAT = (1 << 14), // Only useable in singleplayer / debug / multiplayer & sv_cheats

    FCVAR_PER_USER =
        (1 << 15), // causes varnameN where N == 2 through max splitscreen slots for mod to be autogenerated
    FCVAR_DEMO = (1 << 16), // record this cvar when starting a demo file
    FCVAR_DONTRECORD = (1 << 17), // don't record these command in demofiles
    FCVAR_MISSING2 = (1 << 18),
    FCVAR_RELEASE = (1 << 19), // Cvars tagged with this are the only cvars avaliable to customers
    FCVAR_MENUBAR_ITEM = (1 << 20),
    FCVAR_MISSING3 = (1 << 21),
    FCVAR_NOT_CONNECTED = (1 << 22), // cvar cannot be changed by a client that is connected to a server
    FCVAR_VCONSOLE_FUZZY_MATCHING = (1 << 23),

    FCVAR_SERVER_CAN_EXECUTE =
        (1 << 24), // the server is allowed to execute this command on clients via ClientCommand/NET_StringCmd/CBaseClientState::ProcessStringCmd.
    FCVAR_CLIENT_CAN_EXECUTE = (1 << 25), // Assigned to commands to let clients execute them

    FCVAR_SERVER_CANNOT_QUERY =
        (1 << 26), // If this is set, then the server is not allowed to query this cvar's value (via IServerPluginHelpers::StartQueryCvarValue).
    FCVAR_VCONSOLE_SET_FOCUS = (1 << 27),
    FCVAR_CLIENTCMD_CAN_EXECUTE = (1 << 28), // IVEngineClient::ClientCmd is allowed to execute this command. 
    FCVAR_EXECUTE_PER_TICK = (1 << 29),
}

public enum ConVarType
{
    Invalid = -1,
    Bool,
    Int16,
    UInt16,
    Int32,
    UInt32,
    Int64,
    UInt64,
    Float32,
    Float64,
    String,
    Color,
    Vector2,
    Vector3,
    Vector4,
    Qangle
}

public enum ConCommandFlags
{
    FCVAR_LINKED_CONCOMMAND = (1 << 0),

    FCVAR_DEVELOPMENTONLY =
        (1 << 1), // Hidden in released products. Flag is removed automatically if ALLOW_DEVELOPMENT_CVARS is defined.
    FCVAR_GAMEDLL = (1 << 2), // defined by the game DLL
    FCVAR_CLIENTDLL = (1 << 3), // defined by the client DLL
}
