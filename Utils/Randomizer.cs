﻿using System.Text;

namespace AnyDexDB.Utils {
	public static class Randomizer {
		public static string LoremIpsium(int minLength, int maxLength) {
			// Randomize the length
			int length = Random.Shared.Next(minLength, maxLength + 1);
			// Randomize the starting position
			int maxStartIndex = LoremIpsiumConstant.Length - length - 1;
			int startIndex = Random.Shared.Next(0, maxStartIndex);
			// Step back until the start of a word is found
			while(startIndex > 0 && LoremIpsiumConstant[startIndex - 1] != ' ') {
				startIndex--;
			}
			
			return LoremIpsiumConstant[startIndex..(startIndex + length)];
		}

		public static char RandomLetter(bool randomCase = true) {
			char c = (char)Random.Shared.Next('A', 'Z' + 1);
			if(randomCase && Random.Shared.Next(2) == 1) {
				return char.ToLower(c);
			}
			return c;
		}

		public static DateTime RandomDay()
			=> RandomDay(new DateTime(1950, 1, 1), DateTime.Today);

		public static DateTime RandomDay(DateTime min, DateTime max) {
			int range = (max - min).Days;
			return min.AddDays(Random.Shared.Next(range));
		}

		public static string RandomLetters(int amount, bool randomCase = true) {
			StringBuilder sb = new(amount);
			for(int i = 0; i < amount; i++) {
				sb.Append(RandomLetter(randomCase));
			}

			return sb.ToString();
		}

		public static char RandomLetterOrNumber(bool randomCase) {
			char c = (char)Random.Shared.Next('A', 'Z' + 11);

			if(c > 'Z') {
				return (c - 'Z').ToString()[0];
			}
			
			if(randomCase && Random.Shared.Next(2) == 1) {
				return char.ToLower(c);
			}

			return c;
		}

		public static string RandomLetterOrNumbers(int amount, bool randomCase = true) {
			StringBuilder sb = new(amount);
			for(int i = 0; i < amount; i++) {
				sb.Append(RandomLetterOrNumber(randomCase));
			}

			return sb.ToString();
		}




		/// Since this makes a mess in submodules when using resource files (.resx), keep it as a constant.
		#region Lorem Ipsium
		private const string LoremIpsiumConstant = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id aliquet risus feugiat in ante. Donec ultrices tincidunt arcu non sodales neque sodales. Volutpat maecenas volutpat blandit aliquam etiam erat velit scelerisque in. Dui vivamus arcu felis bibendum ut. Suspendisse in est ante in nibh mauris. Velit scelerisque in dictum non consectetur a. Tristique nulla aliquet enim tortor at auctor urna nunc id. Vivamus at augue eget arcu dictum varius duis at. Non consectetur a erat nam at. Cursus vitae congue mauris rhoncus aenean. Et sollicitudin ac orci phasellus egestas tellus rutrum tellus. Non pulvinar neque laoreet suspendisse interdum consectetur libero id. Pellentesque sit amet porttitor eget dolor morbi. Porta lorem mollis aliquam ut. Ut porttitor leo a diam sollicitudin tempor. Ultrices sagittis orci a scelerisque purus semper. Ultrices eros in cursus turpis massa tincidunt dui. Diam maecenas sed enim ut sem viverra. Vitae tempus quam pellentesque nec nam aliquam sem et tortor.

Duis ut diam quam nulla porttitor massa. Viverra mauris in aliquam sem fringilla. Purus sit amet volutpat consequat mauris. Nunc sed velit dignissim sodales. In nisl nisi scelerisque eu ultrices vitae auctor eu. Eget gravida cum sociis natoque penatibus et. Tellus orci ac auctor augue mauris augue. Convallis convallis tellus id interdum velit. Mus mauris vitae ultricies leo integer malesuada. Fermentum odio eu feugiat pretium nibh ipsum. A diam maecenas sed enim. Fermentum odio eu feugiat pretium nibh ipsum consequat nisl vel. Mauris pharetra et ultrices neque ornare. Penatibus et magnis dis parturient montes nascetur ridiculus mus mauris. Quam nulla porttitor massa id neque aliquam. Laoreet suspendisse interdum consectetur libero. Ut lectus arcu bibendum at varius vel. Est placerat in egestas erat imperdiet sed euismod nisi porta. Proin nibh nisl condimentum id venenatis.

Integer vitae justo eget magna fermentum iaculis eu non diam. Varius duis at consectetur lorem donec massa sapien. Bibendum at varius vel pharetra. Donec ultrices tincidunt arcu non. Mauris rhoncus aenean vel elit scelerisque mauris pellentesque. Tincidunt arcu non sodales neque sodales ut. Tortor pretium viverra suspendisse potenti. A pellentesque sit amet porttitor eget dolor. Ultrices neque ornare aenean euismod elementum nisi quis. Eget est lorem ipsum dolor sit. Urna porttitor rhoncus dolor purus. Non odio euismod lacinia at quis risus sed vulputate. A diam maecenas sed enim ut sem viverra aliquet eget. Nunc pulvinar sapien et ligula ullamcorper. Adipiscing elit ut aliquam purus sit amet luctus. Mattis enim ut tellus elementum sagittis vitae. Tempus imperdiet nulla malesuada pellentesque elit eget gravida cum. Vitae turpis massa sed elementum tempus egestas sed sed risus. Dictumst vestibulum rhoncus est pellentesque elit ullamcorper. Cursus eget nunc scelerisque viverra.

Egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam. Etiam non quam lacus suspendisse. Praesent tristique magna sit amet purus gravida. Ut aliquam purus sit amet luctus venenatis lectus magna. Amet consectetur adipiscing elit pellentesque habitant morbi tristique. Nec feugiat nisl pretium fusce id velit ut tortor. Amet commodo nulla facilisi nullam. Sagittis nisl rhoncus mattis rhoncus. Vitae congue eu consequat ac felis donec et odio. Libero volutpat sed cras ornare. Lacus laoreet non curabitur gravida arcu ac tortor dignissim. Leo urna molestie at elementum eu facilisis. Condimentum mattis pellentesque id nibh tortor id aliquet. Sed id semper risus in hendrerit gravida. Aliquet risus feugiat in ante metus dictum at tempor. Habitasse platea dictumst quisque sagittis purus sit. Quis hendrerit dolor magna eget est lorem ipsum. Nulla facilisi etiam dignissim diam quis enim lobortis scelerisque. Massa massa ultricies mi quis hendrerit dolor.

Iaculis urna id volutpat lacus laoreet non. Id cursus metus aliquam eleifend. Dolor sit amet consectetur adipiscing elit pellentesque. Urna neque viverra justo nec ultrices dui. Nec nam aliquam sem et tortor consequat. Morbi leo urna molestie at elementum eu. Commodo elit at imperdiet dui accumsan sit. Tellus mauris a diam maecenas sed. At auctor urna nunc id. In vitae turpis massa sed elementum tempus egestas. Arcu cursus vitae congue mauris rhoncus aenean vel elit scelerisque. Maecenas accumsan lacus vel facilisis volutpat est velit egestas dui. Pellentesque habitant morbi tristique senectus et netus et malesuada fames. Adipiscing at in tellus integer feugiat scelerisque varius morbi. Eget magna fermentum iaculis eu non. Nibh venenatis cras sed felis eget velit. Egestas integer eget aliquet nibh praesent. Quam viverra orci sagittis eu volutpat odio facilisis mauris sit.

Hendrerit gravida rutrum quisque non tellus orci ac. Fames ac turpis egestas maecenas pharetra. Vulputate dignissim suspendisse in est ante in nibh mauris cursus. Arcu non odio euismod lacinia. Tristique senectus et netus et malesuada fames ac turpis. Elit pellentesque habitant morbi tristique senectus. Quis ipsum suspendisse ultrices gravida dictum fusce. Ultrices vitae auctor eu augue ut lectus arcu. Mattis molestie a iaculis at erat pellentesque adipiscing commodo. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.

Mauris augue neque gravida in. Quisque egestas diam in arcu cursus euismod quis viverra nibh. Nisl pretium fusce id velit ut tortor pretium viverra. Fermentum iaculis eu non diam phasellus vestibulum lorem sed risus. Libero enim sed faucibus turpis in eu mi bibendum neque. At urna condimentum mattis pellentesque id nibh tortor. Metus dictum at tempor commodo ullamcorper a lacus vestibulum sed. Vitae congue eu consequat ac felis donec et. Volutpat sed cras ornare arcu dui vivamus arcu felis bibendum. Pulvinar proin gravida hendrerit lectus a. Proin sed libero enim sed faucibus turpis in. Arcu cursus vitae congue mauris rhoncus aenean vel elit. A lacus vestibulum sed arcu non. Vitae purus faucibus ornare suspendisse. Non enim praesent elementum facilisis. Facilisis magna etiam tempor orci. Duis convallis convallis tellus id interdum velit laoreet id donec.

Lobortis elementum nibh tellus molestie nunc non blandit. Turpis massa tincidunt dui ut ornare. Risus quis varius quam quisque id. Sed egestas egestas fringilla phasellus faucibus scelerisque eleifend donec. Facilisis leo vel fringilla est. Feugiat pretium nibh ipsum consequat nisl vel pretium. Aliquam malesuada bibendum arcu vitae elementum curabitur vitae. Eu scelerisque felis imperdiet proin. Vel orci porta non pulvinar. In nisl nisi scelerisque eu ultrices vitae auctor. Felis eget nunc lobortis mattis aliquam faucibus purus in massa. Ante metus dictum at tempor commodo. Ipsum consequat nisl vel pretium. Quam vulputate dignissim suspendisse in est ante in nibh mauris. Commodo ullamcorper a lacus vestibulum sed arcu. Dui faucibus in ornare quam viverra orci sagittis. Accumsan tortor posuere ac ut consequat semper. Integer eget aliquet nibh praesent tristique magna. Sed turpis tincidunt id aliquet risus feugiat.

Maecenas sed enim ut sem viverra. Congue quisque egestas diam in arcu cursus euismod. Scelerisque viverra mauris in aliquam. Dis parturient montes nascetur ridiculus mus. Consectetur adipiscing elit ut aliquam purus sit. Quam vulputate dignissim suspendisse in est ante in. Vulputate dignissim suspendisse in est ante in nibh mauris cursus. Diam donec adipiscing tristique risus nec. Auctor neque vitae tempus quam. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Ut placerat orci nulla pellentesque. Adipiscing diam donec adipiscing tristique. Eget magna fermentum iaculis eu non diam phasellus vestibulum.

Ullamcorper morbi tincidunt ornare massa eget egestas purus viverra. Cursus risus at ultrices mi. Nulla aliquet porttitor lacus luctus. Quis risus sed vulputate odio ut enim blandit. Commodo viverra maecenas accumsan lacus vel facilisis. Malesuada proin libero nunc consequat. Sit amet aliquam id diam maecenas ultricies mi eget. Donec ultrices tincidunt arcu non sodales. Sapien eget mi proin sed libero enim sed faucibus turpis. Eu non diam phasellus vestibulum lorem sed. Non consectetur a erat nam at lectus urna duis. Elementum nisi quis eleifend quam adipiscing vitae proin sagittis.";
		#endregion
	}
}
