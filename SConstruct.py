#!/usr/bin/env python2

# These import lines are not really needed, but it helps intellisense within VS when editing the script
import SCons.Script
from SCons.Environment import Environment

import os
import os.path as path

env = Environment(ENV = os.environ)

# Build C# Libs
#SConscript('Source/Libs/SConscript.py')

# Build Glue Libs
SConscript('Source/Libs-Glue/SConscript.py')
