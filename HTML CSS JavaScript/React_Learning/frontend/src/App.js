import logo from './logo.svg';
import { DatePicker, Divider, message } from 'antd';
import 'antd/dist/antd.css';
import './index.css';

function heandleChange(date){
  alert (date) 
}

function App() {
  return (
    <>
    <Divider>test</Divider>,
    <DatePicker allowClear={false} onChange={heandleChange}/>
    </>
  );
}

export default App;
