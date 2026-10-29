import os
import pathlib
import re
import subprocess
import tempfile
import unittest


ROOT = pathlib.Path(__file__).resolve().parents[1]
SOURCE = pathlib.Path(os.environ.get('PERO_SOURCE', ROOT / 'Etapa3' / '13 - PERO' / '13 - PERO' / 'Program.cs'))


class MissionCapacityTest(unittest.TestCase):
    def test_registration_accepts_thirtieth_and_rejects_thirty_first(self):
        source = SOURCE.read_text(encoding='utf-8-sig')
        match = re.search(r'if\s*\((cantidadMisiones\s*(?:<|<=)\s*(?:misiones\.GetLength\(0\)|30))\)', source)
        self.assertIsNotNone(match, 'Mission registration guard not found.')
        condition = match.group(1)
        with tempfile.TemporaryDirectory(dir=ROOT) as temp_dir:
            temp = pathlib.Path(temp_dir)
            project = temp / 'CapacityProbe.csproj'
            project.write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net9.0</TargetFramework><StartupObject>Probe</StartupObject><EnableDefaultCompileItems>false</EnableDefaultCompileItems></PropertyGroup><ItemGroup><Compile Include="Program.cs" /></ItemGroup></Project>''', encoding='utf-8')
            program = temp / 'Program.cs'
            program.write_text(f'''using System;
class Probe {{
    static int Main() {{
        int[,] misiones = new int[30, 5];
        int cantidadMisiones = 0, accepted = 0, rejected = 0;
        for (int attempt = 0; attempt < 31; attempt++) {{
            if ({condition}) {{ misiones[cantidadMisiones, 0] = cantidadMisiones + 1; cantidadMisiones++; accepted++; }}
            else rejected++;
        }}
        if (accepted != 30 || rejected != 1 || cantidadMisiones != 30 || misiones[29, 0] != 30)
            throw new Exception("Expected 30 successful registrations and one capacity rejection.");
        Console.WriteLine("30 missions registered; the 31st was rejected.");
        return 0;
    }}
}}''', encoding='utf-8')
            config = temp / 'NuGet.Config'
            config.write_text('<configuration><packageSources><clear /></packageSources></configuration>', encoding='utf-8')
            env = dict(os.environ, DOTNET_CLI_HOME=temp_dir, APPDATA=temp_dir)
            result = subprocess.run(['dotnet', 'restore', str(project), '--configfile', str(config)], capture_output=True, text=True, env=env, timeout=30)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            result = subprocess.run(['dotnet', 'run', '--no-restore', '--project', str(project)], capture_output=True, text=True, env=env, timeout=30)
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
            self.assertIn('30 missions registered; the 31st was rejected.', result.stdout)


if __name__ == '__main__':
    unittest.main()
