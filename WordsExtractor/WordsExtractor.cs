﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsExtractorSample
{
    internal class WordsExtractor
    {
        private string[] _lines;
        private char[] _separators = @" !?"",.".ToCharArray();

        // コンストラクタ
        // ファイル以外からも抽出できるようにstring[]を引数にとる
        public WordsExtractor(string[] lines)
        {
            _lines = lines;
        }

        // 10文字以上の単語を重複なくアルファベット順に列挙する
        public IEnumerable<string> Extract()
        {
            var hash = new HashSet<string>();
            foreach (var line in _lines)
            {
                var words = GetWords(line);
                foreach (var word in words)
                {
                    if (word.Length >= 10)
                    {
                        hash.Add(word.ToLower());
                    }
                }
            }
            return hash.OrderBy(s => s);
        }

        // 1行から単語を取り出し列挙する
        private IEnumerable<string> GetWords(string line)
        {
            var items = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                // you're, it's, dont't などのアポストロフィ以降を取り除く
                var index = item.IndexOf("'");
                var word = index <= 0 ? item : item.Substring(0, index);
                //すべてがアルファベットだけが対象
                if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                {
                    yield return word;
                }
            }
        }
    }
}
