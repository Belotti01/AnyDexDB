﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables {
	[Table("user_token")]
	public class UserToken : IdentityUserToken<ulong> {
	}
}
