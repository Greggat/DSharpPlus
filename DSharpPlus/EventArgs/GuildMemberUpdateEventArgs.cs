﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSharpPlus
{
    public class GuildMemberUpdateEventArgs : EventArgs
    {
<<<<<<< HEAD
        public ulong GuildID;
=======
        internal ulong GuildID;
>>>>>>> master
        public DiscordGuild Guild => DiscordClient.InternalGetGuild(GuildID).Result;
        public List<ulong> Roles;
        public string NickName;
        public DiscordUser User;
    }
}
