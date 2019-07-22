import { data } from '../Resources/Resources'
import LocalizedStrings from 'react-localization';

function GetTranslations()
{
    let  strings= new LocalizedStrings(data)
    function getData()
    {
        return strings;
    }
    function setLanguage(language)
    {
        strings.setLanguage(language);
        return strings;
    }
 return {
    GetData: getData,
    SetLanguage : setLanguage
 }
}
export default GetTranslations;