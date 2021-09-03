/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React, { useState } from 'react';
import type {Node} from 'react';
import {
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  useColorScheme,
  View,
  Button,
} from 'react-native';

import {
  Colors,
  Header,
} from 'react-native/Libraries/NewAppScreen';

const App: () => Node = () => {
  const [bgColor, setBgColor] = useState({
    backgroundColor: isDarkMode ? Colors.darker : Colors.lighter,
  })
  const isDarkMode = useColorScheme() === 'dark';

  function setRed() {
    setBgColor({ backgroundColor: "#FF0000", });
  };

  function setBlue() {
    setBgColor({ backgroundColor: "#0000FF", });
  };

  function setGreen() {
    setBgColor({ backgroundColor: "#00FF00", });
  };

  return (
    <SafeAreaView style={bgColor}>
      <StatusBar barStyle={isDarkMode ? 'light-content' : 'dark-content'} />
      <ScrollView
        contentInsetAdjustmentBehavior="automatic"
        style={bgColor}>
        <Header />
        <View style={bgColor}>
          <Text>This is some text!
            {"\n"}{"\n"}
            This is just for illustration.
          </Text>
          <Button title="Red" accessibilityLabel="red" onPress={setRed} />
          <Button title="Blue" accessibilityLabel="blue" onPress={setBlue} />
          <Button title="Green" accessibilityLabel="green" onPress={setGreen} />
        </View>
      </ScrollView>
    </SafeAreaView>
  );
};

export default App;
