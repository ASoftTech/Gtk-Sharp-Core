# Copyright David Stone 2016.
# Distributed under the Boost Software License, Version 1.0.
# (See accompanying file LICENSE_1_0.txt or copy at
# http://www.boost.org/LICENSE_1_0.txt)

class optimize:
	compile_flags_debug = [
		'-Og',
		'-march=native',
	]

	compile_flags_release = [
		'-Ofast',
		'-march=native',
		'-fipa-pta',
		'-funsafe-loop-optimizations',
		'-flto=4',
	]

	link_flags_debug = []
	link_flags_release = compile_flags_release
