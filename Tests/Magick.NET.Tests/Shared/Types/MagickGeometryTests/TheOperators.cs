﻿// Copyright 2013-2018 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests.Shared.Types
{
    public partial class MagickGeometryTests
    {
        [TestClass]
        public class TheOperators
        {
            [TestMethod]
            public void ShouldReturnTheCorrectValueWhenInstanceIsNull()
            {
                var geometry = new MagickGeometry(10, 5);

                Assert.IsFalse(geometry == null);
                Assert.IsTrue(geometry != null);
                Assert.IsFalse(geometry < null);
                Assert.IsFalse(geometry <= null);
                Assert.IsTrue(geometry > null);
                Assert.IsTrue(geometry >= null);
                Assert.IsFalse(null == geometry);
                Assert.IsTrue(null != geometry);
                Assert.IsTrue(null < geometry);
                Assert.IsTrue(null <= geometry);
                Assert.IsFalse(null > geometry);
                Assert.IsFalse(null >= geometry);
            }

            [TestMethod]
            public void ShouldReturnTheCorrectValueWhenInstanceIsSpecified()
            {
                var first = new MagickGeometry(10, 5);
                var second = new MagickGeometry(5, 5);

                Assert.IsFalse(first == second);
                Assert.IsTrue(first != second);
                Assert.IsFalse(first < second);
                Assert.IsFalse(first <= second);
                Assert.IsTrue(first > second);
                Assert.IsTrue(first >= second);
            }

            [TestMethod]
            public void ShouldReturnTheCorrectValueWhenInstanceHasSameSize()
            {
                var first = new MagickGeometry(10, 5);
                var second = new MagickGeometry(5, 10);

                Assert.IsFalse(first == second);
                Assert.IsTrue(first != second);
                Assert.IsFalse(first < second);
                Assert.IsTrue(first <= second);
                Assert.IsFalse(first > second);
                Assert.IsTrue(first >= second);
            }

            [TestMethod]
            public void ShouldReturnTheCorrectValueWhenInstanceAreEqual()
            {
                var first = new MagickGeometry(10, 5);
                var second = new MagickGeometry(10, 5);

                Assert.IsTrue(first == second);
                Assert.IsFalse(first != second);
                Assert.IsFalse(first < second);
                Assert.IsTrue(first <= second);
                Assert.IsFalse(first > second);
                Assert.IsTrue(first >= second);
            }
        }
    }
}