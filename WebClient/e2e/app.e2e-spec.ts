import { SphinxPage } from './app.po';

describe('sphinx App', () => {
  let page: SphinxPage;

  beforeEach(() => {
    page = new SphinxPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
